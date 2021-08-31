// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.Linux.UnitTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="LinuxUnitTests.shared.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

using NetworkVisor.Core.Test.XUnit.Traits;

namespace NetworkVisor.Core.Test.Linux.UnitTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class LinuxUnitTests.
    /// </summary>
    [PlatformTrait(typeof(LinuxUnitTests))]
    public class LinuxUnitTests : CoreTestBase<LinuxUnitTests, CoreTestFixture<LinuxUnitTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinuxUnitTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public LinuxUnitTests(ITestOutputHelper testOutputHelper, CoreTestFixture<LinuxUnitTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void LinuxUnit_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Linux, TraitTestType.Unit);
        }

        [Fact]
        public void LinuxUnit_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Linux);
        }
    }
}
