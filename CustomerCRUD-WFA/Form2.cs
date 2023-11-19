using CustomerCRUD_WFA.Contexts;
using CustomerCRUD_WFA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerCRUD_WFA
{
    public partial class Form2 : Form
    {
        NorthwindContext db;
        private int id;

        public Form2()
        {
            InitializeComponent();
            db = new NorthwindContext();
        }

        public Form2(int id)
        {
            InitializeComponent();
            db = new NorthwindContext();
            btnIslem.Text = "Update";
            this.id = id;
            DatalariDoldur();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Employee> employees = db.Employees.ToList();
            List<Shipper> shippers = db.Shippers.ToList();
            foreach (Employee emp in employees)
            {
                cbEmployees.Items.Add(emp.FirstName);
            }
            foreach (Shipper shp in shippers)
            {
                cbShipper.Items.Add(shp.CompanyName);
            }
        }

        private void DatalariDoldur()
        {
            Order order = db.Orders.FirstOrDefault(x => x.OrderId == id);
            Employee employee = db.Employees.FirstOrDefault(x => x.EmployeeId == order.EmployeeId);
            Shipper shipper = db.Shippers.FirstOrDefault(x => x.ShipperId == order.ShipVia);

            cbEmployees.Text = employee.FirstName;
            dateTimePicker1.Value = (DateTime)order.OrderDate;
            txtShipCity.Text = order.ShipCity;
            cbShipper.Text = shipper.CompanyName;
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (btnIslem.Text == "Add")
            {
                Order order = new Order();
                Employee employee = db.Employees.FirstOrDefault(x => x.FirstName == cbEmployees.Text);
                Shipper shipper = db.Shippers.FirstOrDefault(x => x.CompanyName == cbShipper.Text);

                order.EmployeeId = employee.EmployeeId;
                order.ShipVia = shipper.ShipperId;

                order.OrderDate = dateTimePicker1.Value;
                order.ShipCity = txtShipCity.Text;


                db.Orders.Add(order);
                MessageBox.Show("Siparisiniz eklendi.");

                db.SaveChanges();
                this.Close();
            }

            if (btnIslem.Text == "Update")
            {
                Order order = db.Orders.FirstOrDefault(x => x.OrderId == id);

                Employee employee = db.Employees.FirstOrDefault(x => x.FirstName == cbEmployees.Text);
                Shipper shipper = db.Shippers.FirstOrDefault(x => x.CompanyName == cbShipper.Text);

                order.EmployeeId = employee.EmployeeId;
                order.ShipVia = shipper.ShipperId;

                order.OrderDate = dateTimePicker1.Value;
                order.ShipCity = txtShipCity.Text;

                MessageBox.Show("Siparisiniz guncellendi.");

                db.SaveChanges();
                this.Close();
            }
        }
    }
}
