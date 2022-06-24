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

namespace Manual1809
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Business_Request recording.
    /// </summary>
    [TestModule("4969f58a-91f4-4740-ad7b-bea3c82368b5", ModuleType.Recording, 1)]
    public partial class Business_Request : ITestModule
    {
        /// <summary>
        /// Holds an instance of the D4H_BPRepository repository.
        /// </summary>
        public static D4H_BPRepository repo = D4H_BPRepository.Instance;

        static Business_Request instance = new Business_Request();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Business_Request()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Business_Request Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.lb_Mytask'", repo.ApplicationUnderTest.lb_MytaskInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.lb_MytaskInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lb_Mytask' at Center.", repo.ApplicationUnderTest.lb_MytaskInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.lb_Mytask.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lb_BusinessRequests' at Center.", repo.ApplicationUnderTest.lb_BusinessRequestsInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.lb_BusinessRequests.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
