using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDeLogin;

namespace ProjetoFluxoDeCaixa3C28
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin2 tela = new frmLogin2();
            tela.ShowDialog();

            if (tela.DialogResult == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }
    }
}
