// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.Linux.IntegrationTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="LinuxIntegrationTests.shared.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace NetworkVisor.Core.Test.Linux.IntegrationTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using NetworkVisor.Core.Test.XUnit.Traits;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class LinuxIntegrationTests.
    /// </summary>
    [PlatformTrait(typeof(LinuxIntegrationTests))]
    public class LinuxIntegrationTests : CoreTestBase<LinuxIntegrationTests, CoreTestFixture<LinuxIntegrationTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinuxIntegrationTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public LinuxIntegrationTests(ITestOutputHelper testOutputHelper, CoreTestFixture<LinuxIntegrationTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void LinuxIntegration_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Linux, TraitTestType.Integration);
        }

        [Fact]
        public void LinuxIntegrationTests_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Linux);
        }
    }
}
