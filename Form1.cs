﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVetor
{
    public partial class FrmVetor : Form
    {
        public FrmVetor()
        {
            InitializeComponent();
        }

        private void FrmVetor_Load(object sender, EventArgs e)
        {
            int[] inteiros = new int[3];

            int[] inteiros1;
            inteiros1 = new int[3];

            int[] inteiros2 = { 2, 3, -4, 5, 6, -20 };

            inteiros[0] = 10;
            inteiros[1] = 22;
            inteiros[2] = 35;

            for (int i = 0; i < inteiros2.Length; i++)
                LstInteiros.Items.Add(inteiros2[i]);

            double[] salarios = new double[10];
            double[] pesos = new double[] { 89.5, 100.2 };
            double[] salarios1 = { 2000.10, 3056.89, 4078.56 };

            string[] nomeFuncionarios = new string[10];
            string[] nomes = { "Vinicius Peres", "João", "Marcelo" };

            foreach (double var in pesos)
            {
                LstInteiros.Items.Add(var);
            }

            LstInteiros.Items.Add("Salarios 1");
            foreach(double varx in salarios1)
            {
                LstInteiros.Items.Add(varx);
            }

            foreach (string varNome in nomes)
                LstInteiros.Items.Add(varNome);


        }
    }
}
