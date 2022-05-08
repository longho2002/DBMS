using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class Borrow : Form
    {
        private string idUser = "";
        private List<object> book_borrow = new List<object>();
        public Borrow()
        {
            InitializeComponent();
            renderListbook();
            renderListbookBorrow();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void tb_searchBook_TextChanged(object sender, EventArgs e)
        {

        }
        //
        // book
        //
        private void renderListbook()
        {
            pan_listBook.Controls.Clear();
            string s = "Cuốn theo chiều gió(Long đẹp trai)";
            for (int i = 0; i < 10; i++)
            {
                pan_listBook.Controls.Add(createBook("2312", s, 8, 17 + (17 + 15) * i));
            }
        }
        private Panel createBook(string id, string name, int x, int y)
        {
            // 
            // label8
            // 8, 17
            Label book = new Label();
            book.AutoSize = true;
            book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book.Location = new System.Drawing.Point(13, 15);
            book.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            book.Size = new System.Drawing.Size(210, 16);
            book.Text = name;
            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };
            //event

            book.MouseHover += changecolorRed;
            book.Click += borrowBook;
            book.MouseLeave += changecolorBlack;

            Panel panBook = new Panel();
            panBook.Controls.Add(lb_id);
            panBook.Controls.Add(book);
            panBook.Location = new System.Drawing.Point(x, y);
            panBook.Size = new System.Drawing.Size(442, 44);

            return panBook;
        }
        private void changecolorRed(object sender, EventArgs e)
        {
            Label a = sender as Label;
            a.ForeColor = Color.Red;
        }
        private void changecolorBlack(object sender, EventArgs e)
        {
            Label a = sender as Label;
            a.ForeColor = Color.Black;
        }
        private void borrowBook(object sender, EventArgs e)
        {
            book_borrow.Add(sender as Panel);
            renderListbook();
            renderListbookBorrow();
        }
        //
        //book borrow
        //
        private void renderListbookBorrow()
        {
            //3, 17
            pan_bookBorrow.Controls.Clear();
            string s = "Cuốn theo chiều gió(Long đẹp trai)";
            for (int i = 0; i < 10; i++)
            {
                pan_bookBorrow.Controls.Add(createBookBorrow("2312", s, 3, 17 + (68 + 15) * i));
            }
        }

        private Panel createBookBorrow(string id, string title, int x, int y)
        {

            Label book = new Label();
            book.AutoSize = true;
            book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book.Location = new System.Drawing.Point(11, 15);
            book.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            book.Size = new System.Drawing.Size(210, 16);
            book.Text = title;

            Label lb_del = new Label();
            lb_del.AutoSize = true;
            lb_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_del.ForeColor = System.Drawing.Color.Red;
            lb_del.Location = new System.Drawing.Point(356, 24);
            lb_del.Size = new System.Drawing.Size(56, 20);
            lb_del.Text = "Delete";


            DateTimePicker d = new DateTimePicker();
            d.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            d.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            d.Location = new System.Drawing.Point(100, 40);
            d.Size = new System.Drawing.Size(127, 20);

            Label lb_ngaytra = new Label();
            lb_ngaytra.AutoSize = true;
            lb_ngaytra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_ngaytra.Location = new System.Drawing.Point(11, 41);
            lb_ngaytra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lb_ngaytra.Size = new System.Drawing.Size(61, 16);
            lb_ngaytra.Text = "Ngày trả:";
            Label lb_id = new Label()
            {
                Text = id,
                Visible = false,
            };

            lb_del.Click += deleteBookBorrow;
            Panel pan_bookQueue = new Panel();
            pan_bookQueue.Controls.Add(lb_id);
            pan_bookQueue.Controls.Add(lb_ngaytra);
            pan_bookQueue.Controls.Add(d);
            pan_bookQueue.Controls.Add(lb_del);
            pan_bookQueue.Controls.Add(book);
            pan_bookQueue.Location = new System.Drawing.Point(x, y);
            pan_bookQueue.Size = new System.Drawing.Size(447, 68);

            return pan_bookQueue;
        }

        private void deleteBookBorrow(object sender, EventArgs e)
        {
            Panel tmp = sender as Panel;
            int c = 0;
            foreach (Panel VARIABLE in pan_bookBorrow.Controls)
            {
                if (VARIABLE != tmp)
                    c++;
                else
                {
                    break;
                }
            }
            // khi co du lieu thi thay 0 bang c
            pan_bookBorrow.Controls.RemoveAt(0);
            renderListbook();
            renderListbookBorrow();
        }
    }
}
