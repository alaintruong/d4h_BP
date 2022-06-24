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
    ///The InputGeneralData recording.
    /// </summary>
    [TestModule("90604256-038b-4a87-ba99-a80b27cb7d52", ModuleType.Recording, 1)]
    public partial class InputGeneralData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the D4H_BPRepository repository.
        /// </summary>
        public static D4H_BPRepository repo = D4H_BPRepository.Instance;

        static InputGeneralData instance = new InputGeneralData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputGeneralData()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputGeneralData Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabGeneralData.lb_GeneralData' at Center.", repo.ApplicationUnderTest.TabGeneralData.lb_GeneralDataInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TabGeneralData.lb_GeneralData.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabGeneralData.txt_BusinessPartner' at Center.", repo.ApplicationUnderTest.TabGeneralData.txt_BusinessPartnerInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TabGeneralData.txt_BusinessPartner.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1009' with focus on 'ApplicationUnderTest.TabGeneralData.txt_BusinessPartner'.", repo.ApplicationUnderTest.TabGeneralData.txt_BusinessPartnerInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TabGeneralData.txt_BusinessPartner.PressKeys("1009");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabGeneralData.txt_Category' at Center.", repo.ApplicationUnderTest.TabGeneralData.txt_CategoryInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.TabGeneralData.txt_Category.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Organization' with focus on 'ApplicationUnderTest.TabGeneralData.txt_Category'.", repo.ApplicationUnderTest.TabGeneralData.txt_CategoryInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.TabGeneralData.txt_Category.PressKeys("Organization");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabGeneralData.txt_Title' at Center.", repo.ApplicationUnderTest.TabGeneralData.txt_TitleInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TabGeneralData.txt_Title.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Company' with focus on 'ApplicationUnderTest.TabGeneralData.txt_Title'.", repo.ApplicationUnderTest.TabGeneralData.txt_TitleInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TabGeneralData.txt_Title.PressKeys("Company");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabGeneralData.txt_Name1' at Center.", repo.ApplicationUnderTest.TabGeneralData.txt_Name1Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.TabGeneralData.txt_Name1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Demo Company' with focus on 'ApplicationUnderTest.TabGeneralData.txt_Name1'.", repo.ApplicationUnderTest.TabGeneralData.txt_Name1Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.TabGeneralData.txt_Name1.PressKeys("Demo Company");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
