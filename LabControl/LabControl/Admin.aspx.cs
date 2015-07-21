using login.Account.App_Domain;
using login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login.Account
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataUser dataUser = new DataUser();
        User user = new User();


        protected void Page_Load(object sender, EventArgs e)
        {/* user = (User)Session["User"];

            if ((User)Session["User"] == null || user.Role != 1)
            {
                Response.Redirect("/Default.aspx");
            }*/

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
            string password = this.generatePassword();
            int i; 
            lblErrorNombre.Visible = false;
            lblErrorCorreo.Visible = false;
            lblErrorCarnet.Visible = false;
          

            //Revisa si los textboxes estan vacidos
            if (txtName.Text.Equals("") || txtEmail.Text.Equals("") || txtStudentId.Text.Equals(""))
            {
                if (txtName.Text.Equals(""))
                    lblErrorNombre.Visible = true;

                if (txtEmail.Text.Equals(""))
                    lblErrorCorreo.Visible = true;

                if (txtStudentId.Text.Equals(""))
                {
                    lblErrorCarnet.Text = "*Carnet no puede estar vacido";
                    lblErrorCarnet.Visible = true;
                }

            }

            else
            {
                //revisa si carnet o rol son numericos
                if (!int.TryParse(txtStudentId.Text, out i))
                {
                    if (!int.TryParse(txtStudentId.Text, out i))
                    {
                        lblErrorCarnet.Text = "*Carnet ocupa ser un numero";
                        lblErrorCarnet.Visible = true;
                    }
                }

                else
                {
                    
                    dataUser.insertUser(txtName.Text, txtEmail.Text, int.Parse(txtStudentId.Text),password, int.Parse(RolList.SelectedValue));
                    this.sendPassword(password);

                    lblNombre.Visible = false;
                    lblEmail.Visible = false;
                    lblStudentId.Visible = false;
                    lblRole.Visible = false;

                    txtName.Visible = false;
                    txtEmail.Visible = false;
                    txtStudentId.Visible = false;
                    RolList.Visible = false;

                    btnCancelar.Visible = false;
                    btnGuardarNewUser.Visible = false;
                    hlbtnCreateUser.Enabled = true;
                }
            } 
        }

        protected void hlbtnCreateUser_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = true;
            lblEmail.Visible = true;
            lblStudentId.Visible = true;
            lblRole.Visible = true;

            txtName.Visible = true;
            txtEmail.Visible = true;
            txtStudentId.Visible = true;
            RolList.Visible = true;
           

            btnGuardarNewUser.Visible = true;
            hlbtnCreateUser.Enabled = false;
            btnCancelar.Visible = true;



        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = false;
            lblEmail.Visible = false;
            lblStudentId.Visible = false;
            lblRole.Visible = false;

            txtName.Visible = false;
            txtEmail.Visible = false;
            txtStudentId.Visible = false;
           
            

            btnGuardarNewUser.Visible = false;
            hlbtnCreateUser.Enabled = true;
            btnCancelar.Visible = false;

            lblErrorNombre.Visible = false;
            lblErrorCorreo.Visible = false;
            lblErrorCarnet.Visible = false;
            RolList.Visible = false;

        }

        protected void Selection_Change(object sender, EventArgs e)
        {

        }

        public string generatePassword()
        {
            Random random = new Random();
            int i = 0;
            char a = '\0';
            String password = "";

            i = random.Next(97, 122);
            a = (char)i;
            password += a;

            i = random.Next(1, 10);
            password += i;

            i = random.Next(97, 122);
            a = (char)i;

            password += a;
            i = random.Next(1, 10);
            password += i;

            i = random.Next(97, 122);
            a = (char)i;

            password += a;
            i = random.Next(1, 10);
            password += i;

            return password;
        }

        public void sendPassword(string password ) {
            var fromAddress = new MailAddress("ukanlos191@gmail.com");
            var toAddress = new MailAddress("" + txtEmail.Text);
            const string fromPassword = "killer58";
            const string subject = "Bienvenido a LabControl";
            string body = "Te damos la bienvenida a LabControl!" + Environment.NewLine + "Nombre:" + txtName.Text + "  Carnet:" + txtStudentId.Text + Environment.NewLine + "Tu contraseña es: " + password + Environment.NewLine + "Por favor cambiarla lo mas pronto possible";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        
        }
    }
}