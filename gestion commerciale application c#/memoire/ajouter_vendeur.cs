using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace memoire
{
    public partial class ajouter_vendeur : Form
    {
        SqlConnection cn = new SqlConnection(@"server = predator\sqlexpress ; DataBase=gestion_commerciale ; Integrated Security=true;");

        public static ajouter_vendeur frm1;
        static void frm1_close_form(object sender, FormClosedEventArgs e)
        {
            frm1 = null;


        }
        public static ajouter_vendeur get_main_form
        {
            get
            {
                if (frm1 == null)
                {
                    frm1 = new ajouter_vendeur();
                    frm1.FormClosed += new FormClosedEventHandler(frm1_close_form);


                }
                return frm1;
            }

        }



        public ajouter_vendeur()
        {
            InitializeComponent();
            if (frm1 == null)
            {
                frm1 = this;

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            insert_vendeur();
            form_vendeur.get_main_form.afficher_vendeur();
        }
        public void insert_vendeur()
        {


            try
            {

                cn.Open();
                SqlCommand cmd9 = new SqlCommand("INSERT INTO employe(username_emp , mdp_emp , nom_emp , type_emp ) VALUES('" + text_username_vend.Text + "' , '" + text_mdp_vend.Text + "' , '" + text_nom_vend.Text + "' , '" + text_type_vend.Text + "' )", cn);
                cmd9.ExecuteNonQuery();
                cn.Close();

                text_username_vend.Text = "";
                text_mdp_vend.Text = "";
                text_nom_vend.Text = "";
                text_type_vend.Text = "";


                MessageBox.Show("ajouté avec succés");
            }
            catch
            {
                MessageBox.Show("une erreur s'est produite");
            }
        }

        private void btn_anuuler_ajout_fourn_Click(object sender, EventArgs e)
        {
            this.panel_ajout_vend.Visible = false;
            form_vendeur.get_main_form.afficher_vendeur();

            form_vendeur.get_main_form.panel_vendeur.Visible = true;
        }
    }
}
