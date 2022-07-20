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

namespace Manual1809_ZEBA_BD1.Approval.ReviewAction
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RejectARequest recording.
    /// </summary>
    [TestModule("9d047b36-6cea-42a8-8056-3c9347dda40f", ModuleType.Recording, 1)]
    public partial class RejectARequest : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repository.
        /// </summary>
        public static global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository repo = global::Manual1809_ZEBA_BD1.Manual1809_ZEBA_BD1Repository.Instance;

        static RejectARequest instance = new RejectARequest();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RejectARequest()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RejectARequest Instance
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

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
