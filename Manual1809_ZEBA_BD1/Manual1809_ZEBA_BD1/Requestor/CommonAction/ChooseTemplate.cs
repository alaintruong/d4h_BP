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
    ///The ChooseTemplate recording.
    /// </summary>
    [TestModule("e93f9af0-e778-464e-8b32-64e1c2a65e34", ModuleType.Recording, 1)]
    public partial class ChooseTemplate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repository.
        /// </summary>
        public static global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repo = global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository.Instance;

        static ChooseTemplate instance = new ChooseTemplate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChooseTemplate()
        {
            varRequestTemplate = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ChooseTemplate Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varRequestTemplate.
        /// </summary>
        [TestVariable("d3a7f53a-178a-4a7a-9092-898348583526")]
        public string varRequestTemplate
        {
            get { return repo.varRequestTemplate; }
            set { repo.varRequestTemplate = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.ChooseTemplate.lb_ChooseTemplate' at Center.", repo.Manual1809_Chrome.ChooseTemplate.lb_ChooseTemplateInfo, new RecordItemIndex(1));
            repo.Manual1809_Chrome.ChooseTemplate.lb_ChooseTemplate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.ChooseTemplate.txt_SearchTemplate' at Center.", repo.Manual1809_Chrome.ChooseTemplate.txt_SearchTemplateInfo, new RecordItemIndex(2));
            repo.Manual1809_Chrome.ChooseTemplate.txt_SearchTemplate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varRequestTemplate' with focus on 'Manual1809_Chrome.ChooseTemplate.txt_SearchTemplate'.", repo.Manual1809_Chrome.ChooseTemplate.txt_SearchTemplateInfo, new RecordItemIndex(3));
            repo.Manual1809_Chrome.ChooseTemplate.txt_SearchTemplate.PressKeys(varRequestTemplate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.ChooseTemplate.btn_SearchAction' at Center.", repo.Manual1809_Chrome.ChooseTemplate.btn_SearchActionInfo, new RecordItemIndex(4));
            repo.Manual1809_Chrome.ChooseTemplate.btn_SearchAction.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Manual1809_Chrome.ChooseTemplate.lb_RequestTemplate' at Center.", repo.Manual1809_Chrome.ChooseTemplate.lb_RequestTemplateInfo, new RecordItemIndex(5));
            repo.Manual1809_Chrome.ChooseTemplate.lb_RequestTemplate.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
