// ***********************************************************************
// Assembly         : LIBRARY.UnitTests
// Author           : SteveBu
// Created          : 08-14-2021
//
// Last Modified By : SteveBu
// Last Modified On : 08-14-2021
// ***********************************************************************
// <copyright file="CoreUnitTests.shared.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace LIBRARY.UnitTests
{
    using FluentAssertions;
    using NetworkVisor.Core.CoreSystem;
    using NetworkVisor.Core.Test;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using NetworkVisor.Core.Test.XUnit.Traits;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class CoreUnitTests.
    /// </summary>
    [PlatformTrait(typeof(CoreUnitTests))]
    public class CoreUnitTests : CoreTestBase<CoreUnitTests, CoreTestFixture<CoreUnitTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoreUnitTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public CoreUnitTests(ITestOutputHelper testOutputHelper, CoreTestFixture<CoreUnitTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void CoreUnit_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Core, TraitTestType.Unit);
        }

        [Fact]
        public void CoreUnit_HasPlatformTraitAttribute()
        {
            this.TestClassType.HasPlatformTraitAttribute().Should().BeTrue();
        }

        [Fact]
        public void CoreUnit_GetTraitOperatingSystem()
        {
            var operatingSystem = new CoreOperatingSystem();

            if (operatingSystem.IsAndroid)
            {
                this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Android);
            }
            else if (operatingSystem.IsIOS)
            {
                this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.IOS);
            }
            else if (operatingSystem.IsMacCatalyst)
            {
                this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.MacCatalyst);
            }
            else if (operatingSystem.IsLinux)
            {
                this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Linux);
            }
            else if (operatingSystem.IsMacOS)
            {
                this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.MacOS);
            }
            else if (operatingSystem.IsWindows)
            {
                this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Windows);
            }
            else
            {
                Assert.True(false, "Unknown OperatingSystemType");
            }
        }

        [Fact]
        public void CoreUnit_GetTraitTestType()
        {
            this.TestClassType.GetTraitTestType().Should().Be(TraitTestType.Unit);
        }

        [Fact]
        public void CoreUnit_OutputTraits()
        {
            this.TestOutputHelper.WriteLine($"TestType: {this.TestClassType.GetTraitTestType()}");
            this.TestOutputHelper.WriteLine($"OS Type: {this.TestClassType.GetTraitOperatingSystem()}");
        }
    }
}
