﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Manual1809_ZEBA_BD1.Requestor.CommonAction
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LogoutRequestor recording.
    /// </summary>
    [TestModule("3e5d5b14-3457-4405-9a3f-549d759df647", ModuleType.Recording, 1)]
    public partial class LogoutRequestor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repository.
        /// </summary>
        public static global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repo = global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository.Instance;

        static LogoutRequestor instance = new LogoutRequestor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogoutRequestor()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogoutRequestor Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.LogoutReuqestor.lb_RequestorIcon' at Center.", repo.Manual1809_Chrome.LogoutReuqestor.lb_RequestorIconInfo, new RecordItemIndex(0));
            repo.Manual1809_Chrome.LogoutReuqestor.lb_RequestorIcon.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.LogoutReuqestor.lb_Logout' at Center.", repo.Manual1809_Chrome.LogoutReuqestor.lb_LogoutInfo, new RecordItemIndex(1));
            repo.Manual1809_Chrome.LogoutReuqestor.lb_Logout.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.LogoutReuqestor.btn_YesConfirm' at Center.", repo.Manual1809_Chrome.LogoutReuqestor.btn_YesConfirmInfo, new RecordItemIndex(2));
            repo.Manual1809_Chrome.LogoutReuqestor.btn_YesConfirm.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.LogoutReuqestor.lb_ConfirmLogout' at Center.", repo.Manual1809_Chrome.LogoutReuqestor.lb_ConfirmLogoutInfo, new RecordItemIndex(4));
            repo.Manual1809_Chrome.LogoutReuqestor.lb_ConfirmLogout.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
