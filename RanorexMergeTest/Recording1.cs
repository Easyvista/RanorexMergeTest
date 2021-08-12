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

namespace RanorexMergeTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("73eadd82-e234-43f3-bbde-77d08ef0f5df", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RanorexMergeTestRepository repository.
        /// </summary>
        public static RanorexMergeTestRepository repo = RanorexMergeTestRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.ranorex.com' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://www.ranorex.com", "Chrome", "", false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestAutomationForGUITestingRanore.Text' at 73;6.", repo.TestAutomationForGUITestingRanore.TextInfo, new RecordItemIndex(1));
            repo.TestAutomationForGUITestingRanore.Text.Click("73;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ranorex' with focus on 'TestAutomationForGUITestingRanore.Text'.", repo.TestAutomationForGUITestingRanore.TextInfo, new RecordItemIndex(2));
            repo.TestAutomationForGUITestingRanore.Text.PressKeys("ranorex");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TestAutomationForGUITestingRanore.GlyphiconGlyphiconSearchGreenSearchIc' at 21;12.", repo.TestAutomationForGUITestingRanore.GlyphiconGlyphiconSearchGreenSearchIcInfo, new RecordItemIndex(3));
            repo.TestAutomationForGUITestingRanore.GlyphiconGlyphiconSearchGreenSearchIc.Click("21;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TestAutomationForGUITestingRanore.WhyRanorexRanorexTestAutomation'.", repo.TestAutomationForGUITestingRanore.WhyRanorexRanorexTestAutomationInfo, new RecordItemIndex(4));
            Validate.Exists(repo.TestAutomationForGUITestingRanore.WhyRanorexRanorexTestAutomationInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
