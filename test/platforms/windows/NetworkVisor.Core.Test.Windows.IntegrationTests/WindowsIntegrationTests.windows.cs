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
namespace NetworkVisor.Core.Test.Windows.IntegrationTests
{
    using FluentAssertions;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using Xunit;
    using Xunit.Abstractions;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.NetworkInformation;
    using Microsoft.Extensions.Logging;
    using NetworkVisor.Core.Abstractions.Extensions;
    using NetworkVisor.Core.Logging.Abstractions.LogProperty;
    using NetworkVisor.Core.Logging.Abstractions.Types;
    using NetworkVisor.Core.Networking.Abstractions;
    using NetworkVisor.Core.Networking.Abstractions.AddressInfo;
    using NetworkVisor.Core.Networking.NetworkInterface;
    using NetworkVisor.Core.Test.XUnit.Traits;
    using NetworkVisor.Core.Networking.Abstractions.Extensions;


    /// <summary>
    /// Class WindowsIntegrationTests.
    /// </summary>
    [PlatformTrait(typeof(WindowsIntegrationTests))]
    public class
        WindowsIntegrationTests : CoreTestBase<WindowsIntegrationTests, CoreTestFixture<WindowsIntegrationTests>>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsIntegrationTests"/> test class.
        /// </summary>
        /// <param name="testOutputHelper">The test output helper used to output to tests.</param>
        /// <param name="testFixture">Test fixture common across all tests.</param>
        public WindowsIntegrationTests(ITestOutputHelper testOutputHelper,
            CoreTestFixture<WindowsIntegrationTests> testFixture)
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
