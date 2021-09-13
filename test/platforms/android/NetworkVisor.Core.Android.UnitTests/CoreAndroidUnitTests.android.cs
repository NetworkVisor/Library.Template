// ***********************************************************************
// Assembly         : NetworkVisor.Core.Android.UnitTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="CoreAndroidUnitTests.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace NetworkVisor.Core.Android.UnitTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using NetworkVisor.Core.Test.XUnit.Traits;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class CoreUnitTests.
    /// </summary>
    [PlatformTrait(typeof(CoreAndroidUnitTests))]
    public class CoreAndroidUnitTests : CoreTestBase<CoreAndroidUnitTests, CoreTestFixture<CoreAndroidUnitTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreAndroidUnitTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public CoreAndroidUnitTests(ITestOutputHelper testOutputHelper,
            CoreTestFixture<CoreAndroidUnitTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void CoreAndroidUnit_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Android, TraitTestType.Unit);
        }

        [Fact]
        public void GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Android);
        }
    }
}
