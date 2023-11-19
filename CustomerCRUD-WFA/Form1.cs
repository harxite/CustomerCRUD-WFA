using CustomerCRUD_WFA.Contexts;
using CustomerCRUD_WFA.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace CustomerCRUD_WFA
{
    public partial class Form1 : Form
    {
        NorthwindContext db;
        string employeeName;
        string shipperName;
        int id;
        int index;
        int index1;
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatalariGetir();
        }

        private void DatalariGetir()
        {

            List<Employee> employees = db.Employees.ToList();
            List<Shipper> shippers = db.Shippers.ToList();
            foreach (Employee emp in employees)
            {
                lstbxEmployees.Items.Add(emp.FirstName);
            }
            foreach (Shipper shp in shippers)
            {
                lstbxShippers.Items.Add(shp.CompanyName);
            }
        }

        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            if (employeeName == null && shipperName == null)
            {
                var ord = from order in db.Orders
                          select new { order.OrderId, order.OrderDate, order.ShipCity };
                dgvOrderList.DataSource = ord.ToList();
            }

            else if (employeeName != null && shipperName == null)
            {
                var ord = from order in db.Orders
                          join employee in db.Employees on order.EmployeeId equals employee.EmployeeId
                          where employee.FirstName == employeeName
                          select new { order.OrderId, order.OrderDate, order.ShipCity };
                dgvOrderList.DataSource = ord.ToList();
            }

            else if (employeeName == null && shipperName != null)
            {
                var ord = from order in db.Orders
                          join shipper in db.Shippers on order.ShipVia equals shipper.ShipperId
                          where shipper.CompanyName == shipperName
                          select new { order.OrderId, order.OrderDate, order.ShipCity };
                dgvOrderList.DataSource = ord.ToList();
            }

            else
            {
                var ord = from order in db.Orders
                          join employee in db.Employees on order.EmployeeId equals employee.EmployeeId
                          join shipper in db.Shippers on order.ShipVia equals shipper.ShipperId
                          where employee.FirstName == employeeName && shipper.CompanyName == shipperName
                          select new { order.OrderId, order.OrderDate, order.ShipCity };
                dgvOrderList.DataSource = ord.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(id);
            form2.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silme islemini onayliyor musunuz?", "Onay mesaji", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Order order = db.Orders.FirstOrDefault(x => x.OrderId == id);
                db.Orders.Remove(order);
                MessageBox.Show("Secilen siparis silindi.");

                db.SaveChanges();
            }
        }

        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            id = (int)dgvOrderList[0, index].Value;
        }

        private void lstbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (index == -1)
            {
                employeeName = null;
            }
            else
            {
                employeeName = lstbxEmployees.SelectedItem.ToString();
            }
        }

        private void lstbxShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (index1 == -1)
            {
                shipperName = null;
            }
            else
            {
                shipperName = lstbxShippers.SelectedItem.ToString();
            }

        }
       
        private void lstbxEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            index = lstbxEmployees.IndexFromPoint(pt);

            if (index <= -1)
            {
                lstbxEmployees.SelectedItems.Clear();
            }
        }

        private void lstbxShippers_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            index1 = lstbxShippers.IndexFromPoint(pt);

            if (index1 <= -1)
            {
                lstbxShippers.SelectedItems.Clear();
            }
        }
    }
}