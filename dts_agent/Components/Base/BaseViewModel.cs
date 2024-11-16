using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using dts_agent.Model;
using dts_agent.Helper;

namespace dts_agent.Components.Base
{
    public class BaseViewModel : BaseModel
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lp1, string lp2);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern Boolean ShowWindow(IntPtr hWnd, Int32 nCmdShow);

        private readonly IView view;

        //Member Type
        protected const string MEMBER = "MEMBER";

        protected const string GUEST = "GUEST";
        protected const string PARTNER = "PARTNER";
        protected const string SUPER_ADMIN = "SUPER ADMIN";
        protected const string TECHNICIAN = "TECHNICIAN";

        public BaseViewModel()
        {
        }

        protected BaseViewModel(IView view)
        {
            this.view = view;
        }
    }
}