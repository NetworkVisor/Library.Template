// ***********************************************************************
// Assembly         : NetworkVisor.Core.Test.MacOS.UnitTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="MacOSUnitTests.macos.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
//     Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace NetworkVisor.Core.Test.MacOS.UnitTests
{
    using System;
    using FluentAssertions;
    using NetworkVisor.Core.Test;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Class MacOSUnitTests.
    /// </summary>
    [PlatformTrait(typeof(MacOSUnitTests))]
    public class MacOSUnitTests
    {
        private readonly ITestOutputHelper testOutputHelper;
        private readonly Type testType = typeof(MacOSUnitTests);

        public MacOSUnitTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void GetTraitOperatingSystem()
        {
            this.testType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.MacOS);
        }
    }
}
