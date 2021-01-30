using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Update.DataContext;
using Update.Models;

namespace Update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetAllBooks();
        }

        private void GetBooks()
        {
            using(TestDbContext context=new TestDbContext())
            {
                var books = context.Books.ToList();
                dgb_test.DataSource = books;
            }
        }

        private void GetAllBooks()
        {
            using(TestDbContext context=new TestDbContext())
            {
                var books = context.Books.Select(book => new
                {
                    book.Id,
                    book.Name,
                    Janre = book.Janr.Name,
                    book.JanrId
                    
                }).ToList();
                dgb_test.DataSource = books;
            }
        }
        
        private void dgb_test_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txb_Name.Text = dgb_test.CurrentRow.Cells[1].Value.ToString();
            txb_JanrId.Text = dgb_test.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_UpdateNew_Click(object sender, EventArgs e)
        {
            
                Book book = new Book()
                {
                    Id = Convert.ToInt32(dgb_test.CurrentRow.Cells[0].Value),
                    Name = txb_Name.Text,
                    JanrId = Convert.ToInt32(txb_JanrId.Text)
                };
            
            
                using (TestDbContext context = new TestDbContext())
                {
                    context.Books.AddOrUpdate(book);
                    context.SaveChanges();
                }


            GetAllBooks();


        }
    }
}
