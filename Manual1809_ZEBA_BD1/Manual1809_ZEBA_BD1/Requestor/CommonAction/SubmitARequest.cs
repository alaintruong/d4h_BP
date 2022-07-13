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
    ///The SubmitARequest recording.
    /// </summary>
    [TestModule("12e60886-0443-4d98-b8ac-3566e0f86d9c", ModuleType.Recording, 1)]
    public partial class SubmitARequest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repository.
        /// </summary>
        public static global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repo = global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository.Instance;

        static SubmitARequest instance = new SubmitARequest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SubmitARequest()
        {
            varGetCRString = "";
            GetCRnumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SubmitARequest Instance
        {
            get { return instance; }
        }

#region Variables

        string _varGetCRString;

        /// <summary>
        /// Gets or sets the value of variable varGetCRString.
        /// </summary>
        [TestVariable("d4d297d5-15dc-4833-815e-43a8dc16d43d")]
        public string varGetCRString
        {
            get { return _varGetCRString; }
            set { _varGetCRString = value; }
        }

        string _GetCRnumber;

        /// <summary>
        /// Gets or sets the value of variable GetCRnumber.
        /// </summary>
        [TestVariable("b827e924-c3b5-4fcc-9adb-baaf0b993025")]
        public string GetCRnumber
        {
            get { return _GetCRnumber; }
            set { _GetCRnumber = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.SubmitABusinessRequest.btn_SubmitAction' at Center.", repo.Manual1809_Chrome.SubmitABusinessRequest.btn_SubmitActionInfo, new RecordItemIndex(0));
            repo.Manual1809_Chrome.SubmitABusinessRequest.btn_SubmitAction.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.SubmitABusinessRequest.txt_CreatRequestDescription' at Center.", repo.Manual1809_Chrome.SubmitABusinessRequest.txt_CreatRequestDescriptionInfo, new RecordItemIndex(1));
            repo.Manual1809_Chrome.SubmitABusinessRequest.txt_CreatRequestDescription.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Please active!' with focus on 'Manual1809_Chrome.SubmitABusinessRequest.txt_CreatRequestDescription'.", repo.Manual1809_Chrome.SubmitABusinessRequest.txt_CreatRequestDescriptionInfo, new RecordItemIndex(2));
            repo.Manual1809_Chrome.SubmitABusinessRequest.txt_CreatRequestDescription.PressKeys("Please active!");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.SubmitABusinessRequest.btn_SubmitConfirm' at Center.", repo.Manual1809_Chrome.SubmitABusinessRequest.btn_SubmitConfirmInfo, new RecordItemIndex(3));
            repo.Manual1809_Chrome.SubmitABusinessRequest.btn_SubmitConfirm.Click();
            Delay.Milliseconds(0);
            
            Get_value_RequestCRSuccessfull(repo.Manual1809_Chrome.SubmitABusinessRequest.lb_RequestCRSuccessfullInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.SubmitABusinessRequest.btn_OKConfirm' at Center.", repo.Manual1809_Chrome.SubmitABusinessRequest.btn_OKConfirmInfo, new RecordItemIndex(5));
            repo.Manual1809_Chrome.SubmitABusinessRequest.btn_OKConfirm.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
