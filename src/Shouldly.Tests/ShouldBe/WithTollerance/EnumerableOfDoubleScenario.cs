﻿using System;
using Shouldly.Tests.TestHelpers;

namespace Shouldly.Tests.ShouldBe.WithTollerance
{
    public class EnumerableOfDoubleScenario : ShouldlyShouldTestScenario
    {
        protected override void ShouldThrowAWobbly()
        {
            new[] { Math.PI, Math.PI }.ShouldBe(new[] { 3.24, 3.24 }, 0.01);
        }

        protected override string ChuckedAWobblyErrorMessage
        {
            get { return "new[] { Math.PI, Math.PI } " +
                         "should be [3.24, 3.24] " +
                         "but was [3.14159265358979, 3.14159265358979] " +
                         "difference [*3.14159265358979*, *3.14159265358979*]"; }
        }

        protected override void ShouldPass()
        {
            new[] { Math.PI, Math.PI }.ShouldBe(new[] { 3.14, 3.14 }, 0.01);
        }
    }
}