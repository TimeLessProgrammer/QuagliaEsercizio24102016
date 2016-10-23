using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuagliaEsercizio24102016
{
  public partial class frm_Index : Form
  {
    public frm_Index()
    {
      InitializeComponent();
    }

    private void frm_Index_Shown(object sender, EventArgs e)
    {
      btn_Es1.Click += (s, o) =>
      {
        Dictionary<int, String> inventory = new Dictionary<int, String>();
        Form frmDict = new Form
        {
          Text = "Esercizio Dizionario",
          MdiParent = this,
          StartPosition = FormStartPosition.CenterScreen,
          Size = new Size(800, 500)
        };
        TextBox txtId = new TextBox { Location = new Point(90, 30) };
        TextBox txtItem = new TextBox { Location = new Point(90, 60) };
        Label lblId = new Label { Location = new Point(10, 34), Text = "Chiave" };
        Label lblItem = new Label { Location = new Point(10, 64), Text = "Articolo" };
        Button btnSalva = new Button
        {
          Location = new Point(600, 350),
          Text = "Salva",
          Anchor = (AnchorStyles.Bottom | AnchorStyles.Right),
          Size = new Size(150, 90)
        };
        Button btnShowDgv = new Button { Location = new Point(90, 90), Text = "Visualizza" };
        DataGridView dgvInventory = new DataGridView
        {
          Location = new Point(400, 10),
          Size = new Size(380, 300),
          Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Left),
          AutoGenerateColumns = true
        };
        Label lblRicerca = new Label { Location = new Point(10, 154), Text = "Cerca" };
        TextBox txtRicerca = new TextBox { Location = new Point(90, 150) };
        Button btnRicerca = new Button { Location = new Point(10, 180), Text = "Cerca" };
        Label lblShowResearch;
        
        int IDVal = 0;
        String Item = "";

        btnSalva.Click += (t, k) =>
        {
          IDVal = Convert.ToInt32(txtId.Text);
          Item = txtItem.Text;

          inventory.Add(IDVal, Item); //argoment out exeception se click su salva più di una volta
          dgvInventory.DataSource = inventory.OrderBy(x => x.Key).ToList();
          Label lbldscrIns = new Label { Location = new Point(10, 120), Text = "Numero Insermenti: " + inventory.Count(), AutoSize = true };
          frmDict.Controls.Add(lbldscrIns);
        };

        btnShowDgv.Click += (t, k) =>
        {
          frmDict.Controls.Add(dgvInventory);
        };

        btnRicerca.Click += (t, k) =>
        {
          if(txtRicerca.Text != "")
          {
            lblShowResearch = new Label { Location = new Point(10, 210), Text = "Risultato: " + inventory[Convert.ToInt32(txtRicerca.Text)] };
            frmDict.Controls.Add(lblShowResearch);
          }
        };

        frmDict.Controls.Add(btnRicerca);
        frmDict.Controls.Add(txtRicerca);
        frmDict.Controls.Add(lblRicerca);
        frmDict.Controls.Add(btnShowDgv);
        frmDict.Controls.Add(btnSalva);
        frmDict.Controls.Add(txtId);
        frmDict.Controls.Add(txtItem);
        frmDict.Controls.Add(lblId);
        frmDict.Controls.Add(lblItem);
        frmDict.Show();
      };

      btn_Es2.Click += (s, o) =>
      {

      };
    }
  }
}
