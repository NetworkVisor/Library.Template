// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.Windows.UnitTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="WindowsUnitTests.windows.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

using NetworkVisor.Core.Test.XUnit.Traits;

namespace NetworkVisor.Core.Test.Windows.UnitTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class WindowsUnitTests.
    /// </summary>
    [PlatformTrait(typeof(WindowsUnitTests))]
    public class WindowsUnitTests : CoreTestBase<WindowsUnitTests, CoreTestFixture<WindowsUnitTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsUnitTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public WindowsUnitTests(ITestOutputHelper testOutputHelper, CoreTestFixture<WindowsUnitTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void WindowsUnit_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Windows, TraitTestType.Unit);
        }

        [Fact]
        public void WindowsUnit_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Windows);
        }
    }
}
