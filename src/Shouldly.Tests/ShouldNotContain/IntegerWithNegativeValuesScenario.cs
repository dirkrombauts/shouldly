﻿using Shouldly.Tests.TestHelpers;

namespace Shouldly.Tests.ShouldNotContain
{
    public class IntegerWithNegativeValuesScenario : ShouldlyShouldTestScenario
    {
        protected override void ShouldThrowAWobbly()
        {
            new[] { 2, 3, 4, 5, 4, 123665, 11234, -1356237712831 }.ShouldNotContain(3);
        }

        protected override string ChuckedAWobblyErrorMessage
        {
            get { return "new[] { 2, 3, 4, 5, 4, 123665, 11234, -1356237712831 } " +
                         "should not contain 3 " +
                         "but was [2, 3, 4, 5, 4, 123665, 11234, -1356237712831]"; }
        }

        protected override void ShouldPass()
        {
            new[] { 2, 3, 4, 5, 4, 123665, 11234, -1356237712831 }.ShouldNotContain(-300);
        }
    }
}