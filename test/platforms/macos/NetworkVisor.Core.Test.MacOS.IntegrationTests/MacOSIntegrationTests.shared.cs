// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.MacOS.IntegrationTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="MacOSIntegrationTests.macos.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

using NetworkVisor.Core.Test.XUnit.Traits;

namespace NetworkVisor.Core.Test.MacOS.IntegrationTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class MacOSIntegrationTests.
    /// </summary>
    [PlatformTrait(typeof(MacOSIntegrationTests))]
    public class MacOSIntegrationTests : CoreTestBase<MacOSIntegrationTests, CoreTestFixture<MacOSIntegrationTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MacOSIntegrationTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public MacOSIntegrationTests(ITestOutputHelper testOutputHelper, CoreTestFixture<MacOSIntegrationTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void MacOSIntegration_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.MacOS, TraitTestType.Integration);
        }

        [Fact]
        public void MacOSIntegration_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.MacOS);
        }
    }
}
