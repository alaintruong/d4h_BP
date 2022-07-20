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
    ///The OpenBrowserChrome recording.
    /// </summary>
    [TestModule("42ecaeff-97d0-4be7-8aa6-6db95ccf3f4d", ModuleType.Recording, 1)]
    public partial class OpenBrowserChrome : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repository.
        /// </summary>
        public static global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repo = global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository.Instance;

        static OpenBrowserChrome instance = new OpenBrowserChrome();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowserChrome()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowserChrome Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://manual-test-s4-1809-simplemdg-web.cfapps.eu10.hana.ondemand.com/' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://manual-test-s4-1809-simplemdg-web.cfapps.eu10.hana.ondemand.com/", "chrome", "", false, false, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
