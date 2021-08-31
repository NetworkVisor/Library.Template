// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.MacCatalyst.UnitTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="MacCatalystUnitTests.maccatalyst.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace NetworkVisor.Core.Test.MacCatalyst.UnitTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using NetworkVisor.Core.Test.XUnit.Traits;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class MacCatalystUnitTests.
    /// </summary>
    [PlatformTrait(typeof(MacCatalystUnitTests))]
    public class MacCatalystUnitTests : CoreTestBase<MacCatalystUnitTests, CoreTestFixture<MacCatalystUnitTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MacCatalystUnitTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public MacCatalystUnitTests(ITestOutputHelper testOutputHelper, CoreTestFixture<MacCatalystUnitTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void MacCatalystUnit_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Windows, TraitTestType.Unit);
        }

        [Fact]
        public void MacCatalystUnit_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.MacCatalyst);
        }
    }
}
