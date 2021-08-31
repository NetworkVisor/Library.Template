// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.IOS.IntegrationTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="IOSIntegrationTests.ios.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace NetworkVisor.Core.Test.IOS.IntegrationTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using NetworkVisor.Core.Test.XUnit.Traits;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class IOSIntegrationTests.
    /// </summary>
    [PlatformTrait(typeof(IOSIntegrationTests))]
    public class IOSIntegrationTests : CoreTestBase<IOSIntegrationTests, CoreTestFixture<IOSIntegrationTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IOSIntegrationTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public IOSIntegrationTests(ITestOutputHelper testOutputHelper, CoreTestFixture<IOSIntegrationTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void IOSIntegration_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Windows, TraitTestType.Integration);
        }

        [Fact]
        public void IOSIntegration_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.IOS);
        }
    }
}
