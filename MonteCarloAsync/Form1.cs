using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MultidimensionalLocalOptimization;

namespace MonteCarloAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {            
            InitializeComponent();
            string[] function = { "Функция Растригина", "Функция потенциальной молекулярной энергии"};            
            cb_func.Items.AddRange(function);

        }
        bool Method = true;
        
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
        }
        
        void FN(int n, double[] x, out double f)
        {
            if (Method)
            {

                f = 10.0 * x.Length;
                for (int i = 0; i < x.Length; i++)
                {
                    f += x[i] * x[i] - 10.0 * Math.Cos(2.0 * Math.PI * x[i]);
                }
            }

            else
            {
                double term = 0.0;                
                int i = 0;
                double L = 0.0;
                f = 0.0;
                for (i = 0; i < x.Length; i++)
                {
                    if  (x[i] < 0.0 || x[i] > 5.0) 
                    {
                        term += x[i] * x[i]; 
                    }

                    L = 1.0 / (Math.Sqrt(10.60099896 - 4.141720682 * Math.Cos(x[i])));
                    if (i % 2 == 0)
                    {
                        
                        L = -L;
                    }
                    f += 1.0 + Math.Cos(3.0 * x[i]) + L;
                }
                f += 10000.0 * term;
            }
        }

        void GRAD(int n, double[] x, double[] g)
        {

        }

        void HESS(int n, double[] x, double[,] H)
        {

        }

        private async void btn_MonteCarlo_Click(object sender, EventArgs e)
        {
            tb_BFGSFopt_Async.Clear();
            lb_BFGSXopt.Items.Clear();
            tb_Fopt_Async.Clear();
            tb_Fopt_Sync.Clear();
            lb_Xn_opt_Async.Items.Clear();
            lb_Xn_opt_Sync.Items.Clear();            
            tb_TimeAsync.Clear();
            tb_TimeSync.Clear();
     
            Random rng = new Random();
            Stopwatch sw = new Stopwatch();
            
            int n = Convert.ToInt32(tB_dimension.Text);
            int N = Convert.ToInt32(tB_repeat.Text);
            int iter = Convert.ToInt32(tB_iter.Text);
            double FoptAsync = double.MaxValue;
            double[] XoptAsync = new double[n];
            double FoptSync = double.MaxValue;
            double[] XoptSync = new double[n];

           
                if (cb_func.SelectedIndex == 0)
            {
                Method = true;
            }
            else { Method = false; }

            sw.Start();
            

            if (rb_1.Checked)
            {
                
                if (cb_func.SelectedIndex == 0)
            {
                sw.Start();
                
                    if (CheckL.GetItemChecked(1))
                    {


                        List<Task<MC.opt>> tAsync = new List<Task<MC.opt>>();
                        List<Task<MC2.opt>> tAsync2 = new List<Task<MC2.opt>>();

                        for (int i = 0; i < N; i++)
                        {
                            tAsync.Add(WCFMonteCarloOptimAsync(n, iter));
                            tAsync2.Add(WCFMonteCarloOptimAsync2(n, iter));
                        }

                        await Task.WhenAll(tAsync);
                        sw.Stop();
                        tb_TimeAsync.Text = sw.Elapsed.ToString();

                        for (int i = 0; i < N; i++)
                        {
                            if (tAsync[i].Result.Fopt < FoptAsync)
                            {
                                FoptAsync = tAsync[i].Result.Fopt;
                                for (int j = 0; j < n; j++)
                                {
                                    XoptAsync[j] = tAsync[i].Result.Xopt[j];
                                }
                            }


                            if (tAsync2[i].Result.Fopt < FoptAsync)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    FoptAsync = tAsync2[i].Result.Fopt;
                                    XoptAsync[j] = tAsync2[i].Result.Xopt[j];
                                }
                            }

                        }



                        tb_Fopt_Async.Text = FoptAsync.ToString();
                        for (int j = 0; j < n; j++)
                        {
                            lb_Xn_opt_Async.Items.Add(XoptAsync[j]);
                        }


                        D_FN FNp = FN;
                        D_GRAD GRADp = GRAD;
                        D_HESS HESSp = HESS;
                        Optimizer opt = new Optimizer(FNp, GRADp, HESSp);

                        double machineps = 1.0E-16;
                        double[] typx = new double[n];
                        double[] X0 = new double[n];
                        double[] Xopt = new double[n];
                        double Fopt = 0.0;
                        int Niter = 0;
                        for (int i = 0; i < n; i++)
                        {
                            X0[i] = XoptAsync[i];
                        }

                        int global = 1;
                        bool analgrad = false,
                             analhess = false,
                             cheapf = true,
                             factsec = false,
                             cdgradb = false;

                        int fdigits = -1,
                             itnlimit = 100000;

                        double typf = 1.0,
                               gradtol = 0.0,
                               steptol = 0.0,
                               maxstep = 100.0;

                        gradtol = Math.Pow(machineps, 1.0 / 3.0);
                        steptol = Math.Pow(machineps, 1.0 / 3.0);

                        for (int i = 0; i < n; i++)
                        { typx[i] = 1.0; }
                        opt.UMDRIVER(n, X0, Xopt, out Fopt, out Niter, global, analgrad, cdgradb, analhess, cheapf, factsec, fdigits, itnlimit, typf, gradtol, steptol, maxstep);

                        tb_BFGSFopt_Async.Text = Fopt.ToString();
                        for (int j = 0; j < n; j++)
                        {
                            lb_BFGSXopt.Items.Add(Xopt[j]);
                        }
                    }

                    if (CheckL.GetItemChecked(0))
                    {
                        sw.Restart();
                        sw.Start();

                        List<MC.opt> tSync = new List<MC.opt>();
                        for (int i = 0; i < N * 2; i++)
                        {
                            tSync.Add(WCFMonteCarloOptim(n, iter));

                        }

                        for (int i = 0; i < N * 2 - 1; i++)
                        {
                            if (tSync[i].Fopt < FoptSync)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    FoptSync = tSync[i].Fopt;
                                    XoptSync[j] = tSync[i].Xopt[j];
                                }
                            }
                        }
                        sw.Stop();
                        tb_TimeSync.Text = sw.Elapsed.ToString();
                        tb_Fopt_Sync.Text = FoptSync.ToString();

                        for (int j = 0; j < n; j++)
                        {
                            lb_Xn_opt_Sync.Items.Add(XoptSync[j]);
                        }
                    }
                
            }
                if (cb_func.SelectedIndex == 1)
            {
                sw.Start();
                
                    if (CheckL.GetItemChecked(1))
                    {
                        List<Task<MC.opt>> tAsync = new List<Task<MC.opt>>();
                        List<Task<MC2.opt>> tAsync2 = new List<Task<MC2.opt>>();
                        for (int i = 0; i < N; i++)
                        {
                            tAsync.Add(WCFMonteCarloOptimAsyncMolecular(n, iter));
                            tAsync2.Add(WCFMonteCarloOptimAsync2Molecular(n, iter));
                        }

                        await Task.WhenAll(tAsync);
                        sw.Stop();
                        tb_TimeAsync.Text = sw.Elapsed.ToString();
                        for (int i = 0; i < N; i++)
                        {
                            if (tAsync[i].Result.Fopt < FoptAsync)
                            {
                                FoptAsync = tAsync[i].Result.Fopt;
                                for (int j = 0; j < n; j++)
                                {
                                    XoptAsync[j] = tAsync[i].Result.Xopt[j];
                                }
                            }


                            if (tAsync2[i].Result.Fopt < FoptAsync)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    FoptAsync = tAsync2[i].Result.Fopt;
                                    XoptAsync[j] = tAsync2[i].Result.Xopt[j];
                                }
                            }

                        }



                        tb_Fopt_Async.Text = FoptAsync.ToString();
                        for (int j = 0; j < n; j++)
                        {
                            lb_Xn_opt_Async.Items.Add(XoptAsync[j]);
                        }


                        D_FN FNp = FN;
                        D_GRAD GRADp = GRAD;
                        D_HESS HESSp = HESS;
                        Optimizer opt = new Optimizer(FNp, GRADp, HESSp);

                        double machineps = 1.0E-16;
                        double[] typx = new double[n];
                        double[] X0 = new double[n];
                        double[] Xopt = new double[n];
                        double Fopt = 0.0;
                        int Niter = 0;
                        for (int i = 0; i < n; i++)
                        {
                            X0[i] = XoptAsync[i];
                        }

                        int global = 1;
                        bool analgrad = false,
                             analhess = false,
                             cheapf = true,
                             factsec = false,
                             cdgradb = false;

                        int fdigits = -1,
                             itnlimit = 100000;

                        double typf = 1.0,
                               gradtol = 0.0,
                               steptol = 0.0,
                               maxstep = 0.01;

                        gradtol = Math.Pow(machineps, 1.0 / 3.0);
                        steptol = Math.Pow(machineps, 1.0 / 3.0);

                        for (int i = 0; i < n; i++)
                        { typx[i] = 1.0; }
                        opt.UMDRIVER(n, X0, Xopt, out Fopt, out Niter, global, analgrad, cdgradb, analhess, cheapf, factsec, fdigits, itnlimit, typf, gradtol, steptol, maxstep);

                        tb_BFGSFopt_Async.Text = Fopt.ToString();
                        for (int j = 0; j < n; j++)
                        {
                            lb_BFGSXopt.Items.Add(Xopt[j]);
                        }
                    }

                    if (CheckL.GetItemChecked(0))
                    {
                        sw.Restart();
                        sw.Start();

                        List<MC.opt> tSync = new List<MC.opt>();
                        for (int i = 0; i < N * 2; i++)
                        {
                            tSync.Add(WCFMonteCarloOptimMolecular(n, iter));

                        }

                        for (int i = 0; i < N * 2 - 1; i++)
                        {
                            if (tSync[i].Fopt < FoptSync)
                            {
                                for (int j = 0; j < n; j++)
                                {
                                    FoptSync = tSync[i].Fopt;
                                    XoptSync[j] = tSync[i].Xopt[j];
                                }
                            }
                        }
                        sw.Stop();
                        tb_TimeSync.Text = sw.Elapsed.ToString();
                        tb_Fopt_Sync.Text = FoptSync.ToString();

                        for (int j = 0; j < n; j++)
                        {
                            lb_Xn_opt_Sync.Items.Add(XoptSync[j]);
                        }

                    }
                
            }
            }

            if (rb_sep.Checked)
            {


                if (CheckL.GetItemChecked(1))
                {
                    List<Task<MC.opt>> tAsync = new List<Task<MC.opt>>();
                    List<Task<MC2.opt>> tAsync2 = new List<Task<MC2.opt>>();
                    for (int i = 0; i < N; i++)
                    {
                        tAsync.Add(WCFMonteCarloOptimAsyncMolecularSeparability(n, iter));
                        tAsync2.Add(WCFMonteCarloOptimAsync2MolecularSeparability(n, iter));
                    }

                    await Task.WhenAll(tAsync);
                    sw.Stop();
                    tb_TimeAsync.Text = sw.Elapsed.ToString();
                    for (int i = 0; i < N; i++)
                    {
                        if (tAsync[i].Result.Fopt < FoptAsync)
                        {
                            FoptAsync = tAsync[i].Result.Fopt;
                            for (int j = 0; j < n; j++)
                            {
                                XoptAsync[j] = tAsync[i].Result.Xopt[j];
                            }
                        }


                        if (tAsync2[i].Result.Fopt < FoptAsync)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                FoptAsync = tAsync2[i].Result.Fopt;
                                XoptAsync[j] = tAsync2[i].Result.Xopt[j];
                            }
                        }

                    }



                    tb_Fopt_Async.Text = FoptAsync.ToString();
                    for (int j = 0; j < n; j++)
                    {
                        lb_Xn_opt_Async.Items.Add(XoptAsync[j]);
                    }


                    D_FN FNp = FN;
                    D_GRAD GRADp = GRAD;
                    D_HESS HESSp = HESS;
                    Optimizer opt = new Optimizer(FNp, GRADp, HESSp);

                    double machineps = 1.0E-16;
                    double[] typx = new double[n];
                    double[] X0 = new double[n];
                    double[] Xopt = new double[n];
                    double Fopt = 0.0;
                    int Niter = 0;
                    for (int i = 0; i < n; i++)
                    {
                        X0[i] = XoptAsync[i];
                    }

                    int global = 1;
                    bool analgrad = false,
                         analhess = false,
                         cheapf = true,
                         factsec = false,
                         cdgradb = false;

                    int fdigits = -1,
                         itnlimit = 100000;

                    double typf = 1.0,
                           gradtol = 0.0,
                           steptol = 0.0,
                           maxstep = 0.01;

                    gradtol = Math.Pow(machineps, 1.0 / 3.0);
                    steptol = Math.Pow(machineps, 1.0 / 3.0);

                    for (int i = 0; i < n; i++)
                    { typx[i] = 1.0; }
                    opt.UMDRIVER(n, X0, Xopt, out Fopt, out Niter, global, analgrad, cdgradb, analhess, cheapf, factsec, fdigits, itnlimit, typf, gradtol, steptol, maxstep);

                    tb_BFGSFopt_Async.Text = Fopt.ToString();
                    for (int j = 0; j < n; j++)
                    {
                        lb_BFGSXopt.Items.Add(Xopt[j]);
                    }
                }

                if (CheckL.GetItemChecked(0))
                {
                    sw.Restart();
                    sw.Start();

                    List<MC.opt> tSync = new List<MC.opt>();
                    for (int i = 0; i < N * 2; i++)
                    {
                        tSync.Add(WCFMonteCarloOptimMolecularSeparability(n, iter));

                    }

                    for (int i = 0; i < N * 2 - 1; i++)
                    {
                        if (tSync[i].Fopt < FoptSync)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                FoptSync = tSync[i].Fopt;
                                XoptSync[j] = tSync[i].Xopt[j];
                            }
                        }
                    }
                    sw.Stop();
                    tb_TimeSync.Text = sw.Elapsed.ToString();
                    tb_Fopt_Sync.Text = FoptSync.ToString();

                    for (int j = 0; j < n; j++)
                    {
                        lb_Xn_opt_Sync.Items.Add(XoptSync[j]);
                    }

                }
            }

        }

        MC.opt WCFMonteCarloOptim(int n, int iter)
        {
           
                System.Net.ServicePointManager.Expect100Continue = false;
                MC.Service1Client srv =
                new MC.Service1Client();

                MC.opt t1 = srv.MonteCarloOptim(n, iter);

                return t1;
           
        }

        MC2.opt WCFMonteCarloOptim2(int n, int iter)
        {

            System.Net.ServicePointManager.Expect100Continue = false;
            MC2.Service1Client srv =
            new MC2.Service1Client();

            MC2.opt t1 = srv.MonteCarloOptim(n, iter);

            return t1;

        }

        Task<MC.opt> WCFMonteCarloOptimAsync(int n, int iter)
        {
            return Task.Run<MC.opt>(() =>
            {
                return WCFMonteCarloOptim(n, iter);
            });
        }

        Task<MC2.opt> WCFMonteCarloOptimAsync2(int n, int iter)
        {
            return Task.Run<MC2.opt>(() =>
            {
                return WCFMonteCarloOptim2(n, iter);
            });
        }

        MC.opt WCFMonteCarloOptimMolecular(int n, int iter)
        {

            System.Net.ServicePointManager.Expect100Continue = false;
            MC.Service1Client srv =
            new MC.Service1Client();

            MC.opt t1 = srv.MonteCarloOptimMolecular(n, iter);

            return t1;

        }

        MC2.opt WCFMonteCarloOptim2Molecular(int n, int iter)
        {

            System.Net.ServicePointManager.Expect100Continue = false;
            MC2.Service1Client srv =
            new MC2.Service1Client();

            MC2.opt t1 = srv.MonteCarloOptimMolecular(n, iter);

            return t1;

        }

        Task<MC.opt> WCFMonteCarloOptimAsyncMolecular(int n, int iter)
        {
            return Task.Run<MC.opt>(() =>
            {
                return WCFMonteCarloOptimMolecular(n, iter);
            });
        }

        Task<MC2.opt> WCFMonteCarloOptimAsync2Molecular(int n, int iter)
        {
            return Task.Run<MC2.opt>(() =>
            {
                return WCFMonteCarloOptim2Molecular(n, iter);
            });
        }

        MC.opt WCFMonteCarloOptimMolecularSeparability(int n, int iter)
        {

            System.Net.ServicePointManager.Expect100Continue = false;
            MC.Service1Client srv =
            new MC.Service1Client();

            MC.opt t1 = srv.MonteCarloOptimMolecularSeparability(n, iter);

            return t1;

        }

        MC2.opt WCFMonteCarloOptim2MolecularSeparability(int n, int iter)
        {

            System.Net.ServicePointManager.Expect100Continue = false;
            MC2.Service1Client srv =
            new MC2.Service1Client();

            MC2.opt t1 = srv.MonteCarloOptimMolecularSeparability(n, iter);

            return t1;

        }

        Task<MC.opt> WCFMonteCarloOptimAsyncMolecularSeparability(int n, int iter)
        {
            return Task.Run<MC.opt>(() =>
            {
                return WCFMonteCarloOptimMolecularSeparability(n, iter);
            });
        }

        Task<MC2.opt> WCFMonteCarloOptimAsync2MolecularSeparability(int n, int iter)
        {
            return Task.Run<MC2.opt>(() =>
            {
                return WCFMonteCarloOptim2MolecularSeparability(n, iter);
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CopyXoptAsync_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in lb_Xn_opt_Async.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
        }

        private void btn_CopyBFGSXoptAync_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in lb_BFGSXopt.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
        }

        private void btn_CopyXoptSync_Click(object sender, EventArgs e)
        {
            string s1 = "";
            foreach (object item in lb_Xn_opt_Sync.Items) s1 += item.ToString() + "\r\n";
            Clipboard.SetText(s1);
        }

        private void CheckL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
