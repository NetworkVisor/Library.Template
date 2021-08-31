// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.IOS.UnitTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="IOSUnitTests.ios.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace NetworkVisor.Core.Test.IOS.UnitTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using NetworkVisor.Core.Test.XUnit.Traits;
    using Xunit;
    using Xunit.Abstractions;
    
    /// <summary>
    /// Class IOSUnitTests.
    /// </summary>
    [PlatformTrait(typeof(IOSUnitTests))]
    public class IOSUnitTests : CoreTestBase<IOSUnitTests, CoreTestFixture<IOSUnitTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IOSUnitTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public IOSUnitTests(ITestOutputHelper testOutputHelper, CoreTestFixture<IOSUnitTests> testFixture)
            : base(testOutputHelper, testFixture)
        {

        }

        [Fact]
        public void IOSUnit_ValidateTestClass()
        {
            this.ValidateTestClass(TraitOperatingSystem.Windows, TraitTestType.Unit);
        }

        [Fact]
        public void IOSUnit_GetTraitOperatingSystem()
        {
            this.TestClassType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.IOS);
        }
    }
}
