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

namespace D4H_BP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Business_Request recording.
    /// </summary>
    [TestModule("899c7b9a-d905-4555-8115-74fa46d3597e", ModuleType.Recording, 1)]
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

        /// <summary>
        /// Gets or sets the value of variable domainname.
        /// </summary>
        [TestVariable("a17ded76-ebae-484c-b62c-6174d0eef3d4")]
        public string domainname
        {
            get { return repo.domainname; }
            set { repo.domainname = value; }
        }

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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lb_Mytask' at Center.", repo.ApplicationUnderTest.lb_MytaskInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.lb_Mytask.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lb_BusinessRequests' at Center.", repo.ApplicationUnderTest.lb_BusinessRequestsInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.lb_BusinessRequests.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
