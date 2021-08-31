// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.MacCatalyst.IntegrationTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="MacCatalystIntegrationTests.maccatalyst.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace NetworkVisor.Core.Test.MacCatalyst.IntegrationTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using NetworkVisor.Core.Test.XUnit.Traits;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class MacCatalystIntegrationTests.
    /// </summary>
    [PlatformTrait(typeof(MacCatalystIntegrationTests))]
    public class MacCatalystIntegrationTests : CoreTestBase<MacCatalystIntegrationTests, CoreTestFixture<MacCatalystIntegrationTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MacCatalystIntegrationTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public MacCatalystIntegrationTests(ITestOutputHelper testOutputHelper, CoreTestFixture<MacCatalystIntegrationTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void MacCatalystIntegration_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Windows, TraitTestType.Integration);
        }

        [Fact]
        public void MacCatalystIntegration_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.MacCatalyst);
        }
    }
}
