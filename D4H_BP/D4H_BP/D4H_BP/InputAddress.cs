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
    ///The InputAddress recording.
    /// </summary>
    [TestModule("e82b91f2-da57-446b-9887-b05a4d9883a0", ModuleType.Recording, 1)]
    public partial class InputAddress : ITestModule
    {
        /// <summary>
        /// Holds an instance of the D4H_BPRepository repository.
        /// </summary>
        public static D4H_BPRepository repo = D4H_BPRepository.Instance;

        static InputAddress instance = new InputAddress();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InputAddress()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InputAddress Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.Tab_Address' at Center.", repo.ApplicationUnderTest.TabAddress.Tab_AddressInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.TabAddress.Tab_Address.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.txt_District' at Center.", repo.ApplicationUnderTest.TabAddress.txt_DistrictInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.TabAddress.txt_District.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Da Nang' with focus on 'ApplicationUnderTest.TabAddress.txt_District'.", repo.ApplicationUnderTest.TabAddress.txt_DistrictInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TabAddress.txt_District.PressKeys("Da Nang");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.txt_PostalCode' at Center.", repo.ApplicationUnderTest.TabAddress.txt_PostalCodeInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.TabAddress.txt_PostalCode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '70000' with focus on 'ApplicationUnderTest.TabAddress.txt_PostalCode'.", repo.ApplicationUnderTest.TabAddress.txt_PostalCodeInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.TabAddress.txt_PostalCode.PressKeys("70000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.txt_City' at Center.", repo.ApplicationUnderTest.TabAddress.txt_CityInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TabAddress.txt_City.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'HCM' with focus on 'ApplicationUnderTest.TabAddress.txt_City'.", repo.ApplicationUnderTest.TabAddress.txt_CityInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TabAddress.txt_City.PressKeys("HCM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.Btn_SelectCountry' at Center.", repo.ApplicationUnderTest.TabAddress.Btn_SelectCountryInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.TabAddress.Btn_SelectCountry.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.txt_SearchCountry' at Center.", repo.ApplicationUnderTest.TabAddress.txt_SearchCountryInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.TabAddress.txt_SearchCountry.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'USA' with focus on 'ApplicationUnderTest.TabAddress.txt_SearchCountry'.", repo.ApplicationUnderTest.TabAddress.txt_SearchCountryInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.TabAddress.txt_SearchCountry.PressKeys("USA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.Btn_SearchCountry' at Center.", repo.ApplicationUnderTest.TabAddress.Btn_SearchCountryInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.TabAddress.Btn_SearchCountry.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.lb_SelectCountry' at Center.", repo.ApplicationUnderTest.TabAddress.lb_SelectCountryInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.TabAddress.lb_SelectCountry.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.Btn_AddEmailIcon' at Center.", repo.ApplicationUnderTest.TabAddress.Btn_AddEmailIconInfo, new RecordItemIndex(12));
            //repo.ApplicationUnderTest.TabAddress.Btn_AddEmailIcon.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.txt_Email' at Center.", repo.ApplicationUnderTest.TabAddress.txt_EmailInfo, new RecordItemIndex(13));
            //repo.ApplicationUnderTest.TabAddress.txt_Email.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'alaintruong@gmail.com' with focus on 'ApplicationUnderTest.TabAddress.txt_Email'.", repo.ApplicationUnderTest.TabAddress.txt_EmailInfo, new RecordItemIndex(14));
            //repo.ApplicationUnderTest.TabAddress.txt_Email.PressKeys("alaintruong@gmail.com");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TabAddress.Btn_AddEmail' at Center.", repo.ApplicationUnderTest.TabAddress.Btn_AddEmailInfo, new RecordItemIndex(15));
            //repo.ApplicationUnderTest.TabAddress.Btn_AddEmail.Click();
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
