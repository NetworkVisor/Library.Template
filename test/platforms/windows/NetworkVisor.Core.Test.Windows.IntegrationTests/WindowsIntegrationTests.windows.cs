// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.Windows.IntegrationTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="WindowsIntegrationTests.windows.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

using NetworkVisor.Core.Test.XUnit.Traits;

namespace NetworkVisor.Core.Test.Windows.IntegrationTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class WindowsIntegrationTests.
    /// </summary>
    [PlatformTrait(typeof(WindowsIntegrationTests))]
    public class WindowsIntegrationTests : CoreTestBase<WindowsIntegrationTests, CoreTestFixture<WindowsIntegrationTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsIntegrationTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public WindowsIntegrationTests(ITestOutputHelper testOutputHelper, CoreTestFixture<WindowsIntegrationTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void WindowsIntegration_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Windows, TraitTestType.Integration);
        }

        [Fact]
        public void WindowsIntegration_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Windows);
        }
    }
}
