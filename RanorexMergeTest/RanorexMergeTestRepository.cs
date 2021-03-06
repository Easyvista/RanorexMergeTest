///////////////////////////////////////////////////////////////////////////////
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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace RanorexMergeTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the RanorexMergeTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("32295630-aeeb-42cd-b32b-aef0c7664898")]
    public partial class RanorexMergeTestRepository : RepoGenBaseFolder
    {
        static RanorexMergeTestRepository instance = new RanorexMergeTestRepository();
        RanorexMergeTestRepositoryFolders.ExplorerAppFolder _explorer;
        RanorexMergeTestRepositoryFolders.TestAutomationForGUITestingRanoreAppFolder _testautomationforguitestingranore;

        /// <summary>
        /// Gets the singleton class instance representing the RanorexMergeTestRepository element repository.
        /// </summary>
        [RepositoryFolder("32295630-aeeb-42cd-b32b-aef0c7664898")]
        public static RanorexMergeTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public RanorexMergeTestRepository() 
            : base("RanorexMergeTestRepository", "/", null, 0, false, "32295630-aeeb-42cd-b32b-aef0c7664898", ".\\RepositoryImages\\RanorexMergeTestRepository32295630.rximgres")
        {
            _explorer = new RanorexMergeTestRepositoryFolders.ExplorerAppFolder(this);
            _testautomationforguitestingranore = new RanorexMergeTestRepositoryFolders.TestAutomationForGUITestingRanoreAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("32295630-aeeb-42cd-b32b-aef0c7664898")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("e398f7ce-111e-4188-b7fe-7624894de802")]
        public virtual RanorexMergeTestRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The TestAutomationForGUITestingRanore folder.
        /// </summary>
        [RepositoryFolder("ebc072c5-8349-4a4a-a9b2-216b1358f748")]
        public virtual RanorexMergeTestRepositoryFolders.TestAutomationForGUITestingRanoreAppFolder TestAutomationForGUITestingRanore
        {
            get { return _testautomationforguitestingranore; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class RanorexMergeTestRepositoryFolders
    {
        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("e398f7ce-111e-4188-b7fe-7624894de802")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _googlechrome1fenetreencoursdexecInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "e398f7ce-111e-4188-b7fe-7624894de802", "")
            {
                _googlechrome1fenetreencoursdexecInfo = new RepoItemInfo(this, "GoogleChrome1FenetreEnCoursDexec", ".//toolbar[@accessiblename>'Applications en cours d’e']/button[22]", 30000, null, "e0e0d262-a799-4823-90f8-a478fe44a5fa");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e398f7ce-111e-4188-b7fe-7624894de802")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e398f7ce-111e-4188-b7fe-7624894de802")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The GoogleChrome1FenetreEnCoursDexec item.
            /// </summary>
            [RepositoryItem("e0e0d262-a799-4823-90f8-a478fe44a5fa")]
            public virtual Ranorex.Button GoogleChrome1FenetreEnCoursDexec
            {
                get
                {
                    return _googlechrome1fenetreencoursdexecInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The GoogleChrome1FenetreEnCoursDexec item info.
            /// </summary>
            [RepositoryItemInfo("e0e0d262-a799-4823-90f8-a478fe44a5fa")]
            public virtual RepoItemInfo GoogleChrome1FenetreEnCoursDexecInfo
            {
                get
                {
                    return _googlechrome1fenetreencoursdexecInfo;
                }
            }
        }

        /// <summary>
        /// The TestAutomationForGUITestingRanoreAppFolder folder.
        /// </summary>
        [RepositoryFolder("ebc072c5-8349-4a4a-a9b2-216b1358f748")]
        public partial class TestAutomationForGUITestingRanoreAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textInfo;
            RepoItemInfo _glyphiconglyphiconsearchgreensearchicInfo;
            RepoItemInfo _whyranorexranorextestautomationInfo;

            /// <summary>
            /// Creates a new TestAutomationForGUITestingRanore  folder.
            /// </summary>
            public TestAutomationForGUITestingRanoreAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TestAutomationForGUITestingRanore", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "ebc072c5-8349-4a4a-a9b2-216b1358f748", "")
            {
                _textInfo = new RepoItemInfo(this, "Text", ".//div[#'rx-header-fixed']/div//form[@action='https://www.ranorex.com/']/?/?/input[@type='text']", 30000, null, "2f86ba15-cb84-49ea-b927-23b848b49cf5");
                _glyphiconglyphiconsearchgreensearchicInfo = new RepoItemInfo(this, "GlyphiconGlyphiconSearchGreenSearchIc", ".//div[#'rx-header-fixed']/div//form[@action='https://www.ranorex.com/']/div/span", 30000, null, "24fc2b4d-18bb-4403-b064-c2b507eee901");
                _whyranorexranorextestautomationInfo = new RepoItemInfo(this, "WhyRanorexRanorexTestAutomation", ".//div[#'rx-content']//ul/div/li[1]/h3/a[@innertext>'Why Ranorex | Ranorex Test']", 30000, null, "543f02ea-7b46-4e1d-899c-ffdc8054ebea");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ebc072c5-8349-4a4a-a9b2-216b1358f748")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ebc072c5-8349-4a4a-a9b2-216b1358f748")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("2f86ba15-cb84-49ea-b927-23b848b49cf5")]
            public virtual Ranorex.InputTag Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("2f86ba15-cb84-49ea-b927-23b848b49cf5")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The GlyphiconGlyphiconSearchGreenSearchIc item.
            /// </summary>
            [RepositoryItem("24fc2b4d-18bb-4403-b064-c2b507eee901")]
            public virtual Ranorex.SpanTag GlyphiconGlyphiconSearchGreenSearchIc
            {
                get
                {
                    return _glyphiconglyphiconsearchgreensearchicInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The GlyphiconGlyphiconSearchGreenSearchIc item info.
            /// </summary>
            [RepositoryItemInfo("24fc2b4d-18bb-4403-b064-c2b507eee901")]
            public virtual RepoItemInfo GlyphiconGlyphiconSearchGreenSearchIcInfo
            {
                get
                {
                    return _glyphiconglyphiconsearchgreensearchicInfo;
                }
            }

            /// <summary>
            /// The WhyRanorexRanorexTestAutomation item.
            /// </summary>
            [RepositoryItem("543f02ea-7b46-4e1d-899c-ffdc8054ebea")]
            public virtual Ranorex.ATag WhyRanorexRanorexTestAutomation
            {
                get
                {
                    return _whyranorexranorextestautomationInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The WhyRanorexRanorexTestAutomation item info.
            /// </summary>
            [RepositoryItemInfo("543f02ea-7b46-4e1d-899c-ffdc8054ebea")]
            public virtual RepoItemInfo WhyRanorexRanorexTestAutomationInfo
            {
                get
                {
                    return _whyranorexranorextestautomationInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
