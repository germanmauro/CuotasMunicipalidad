using BLL;
using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMyG
{
    public partial class Fotos : Form
    {
        public inventario Inventario { get; set; }
        public Fotos()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            label1.Text = "Fotos de: " + Inventario.nombre + " (Click en la imagen para eliminarla)";
            ActualizarGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validador.VeficarForm(this))
            {
               
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CargarFoto();
        }

        public void CargarFoto()
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string path = "Inventario/";
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                var fileName = Path.GetFileName(dialog.FileName);
                path += Inventario.nombre + "_" + Inventario.id.ToString()+ "_"+ fileName;
                while(File.Exists(path))
                {
                    path += "(1)";
                }
                File.Copy(dialog.FileName, path);
                Datos.inventario_foto inv = new Datos.inventario_foto();
                inv.foto = path;
                inv.inventario_id = Inventario.id;
                InventarioFotoService.Guardar(inv);
                ActualizarGrilla();
            }
        }

        #region Metodos
        private void ActualizarGrilla()
        {
            LimpiarImagenes();
            var lista = BLL.InventarioFotoService.Listar(Inventario.id);
            int x = 10;
            int y = 40;
            foreach (var item in lista)
            {
                PictureBox pic = new PictureBox();
                pic.Name = item.Id.ToString();
                pic.ImageLocation = item.Nombre;
                pic.Width = 260;
                pic.Height = 260;
                pic.BorderStyle = BorderStyle.Fixed3D;
                //pic.Size = new Size(pic.Width, pic.Height);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                Point ubicacion = new Point(x,y);
                pic.Location = ubicacion;
                pic.Click += ImagenClick;
                this.Controls.Add(pic);
                x += 270;
            }
            ActualizarVista();
        }
        private void LimpiarImagenes()
        {
            foreach (Control item in this.Controls)
            {
                if(item.GetType() == typeof(PictureBox))
                {
                    this.Controls.Remove(item);
                    item.Dispose();
                }
            }
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(PictureBox))
                {
                    this.Controls.Remove(item);
                    item.Dispose();
                }
            }
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(PictureBox))
                {
                    this.Controls.Remove(item);
                    item.Dispose();
                }
            }
            this.Refresh();
        }

        private void ActualizarVista()
        {
            btnNuevo.Enabled = InventarioService.cantidadFotos(Inventario.id);
        }

        #endregion

        private void ImagenClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea realizar la eliminación?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Datos.inventario_foto ent = InventarioFotoService.Obtener(int.Parse(((PictureBox)sender).Name));
                File.Delete(ent.foto);
                BLL.InventarioFotoService.Eliminar(ent);

                ActualizarGrilla();
            }
        }
    }
}
