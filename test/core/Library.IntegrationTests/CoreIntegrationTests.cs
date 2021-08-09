// ***********************************************************************
// Assembly         : LIBRARY.IntegrationTests
// Author           : SteveBu
// Created          : 04-20-2020
//
// Last Modified By : SteveBu
// Last Modified On : 04-20-2020
// ***********************************************************************
// <copyright file="CoreIntegrationTests.cs" company="BushChang Corporation">
//     Copyright (c) BushChang Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace LIBRARY.IntegrationTests
{
    using LIBRARY;
    using System;
    using FluentAssertions;
    using NetworkVisor.Core.Test;
    using NetworkVisor.Core.Test.XUnit;
    using NetworkVisor.Core.Test.XUnit.Extensions;
    using Xunit.Abstractions;

    /// <summary>
    /// Class CoreIntegrationTests.
    /// </summary>
    [PlatformTrait(typeof(CoreIntegrationTests))]
    public class CoreIntegrationTests
    {
        private readonly ITestOutputHelper testOutputHelper;
        private readonly Type testType = typeof(CoreIntegrationTests);

        public CoreIntegrationTests(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void CalculatorIntegrationTest()
        {
            // This tests aggregation of code coverage across test runs.
#if NETCOREAPP2_1
            Calculator.Add(1, 2).Should().Be(3);
#else
            Calculator.Subtract(1, 2).Should().Be(-1);
#endif
        }

        [Fact]
        public void HasPlatformTraitAttribute()
        {
            this.testType.HasPlatformTraitAttribute().Should().BeTrue();
        }

        [Fact]
        public void GetTraitOperatingSystem()
        {
            this.testType.GetTraitOperatingSystem().Should().Be(TraitOperatingSystem.Core);
        }

        [Fact]
        public void GetTraitTestType()
        {
            this.testType.GetTraitTestType().Should().Be(TraitTestType.Integration);
        }

        [Fact]
        public void OutputTraits()
        {
            this.testOutputHelper.WriteLine($"TestType: {this.testType.GetTraitTestType()}");
            this.testOutputHelper.WriteLine($"OS Type: {this.testType.GetTraitOperatingSystem()}");
        }
    }
}
