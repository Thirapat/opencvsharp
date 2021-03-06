﻿using Xunit;

namespace OpenCvSharp.Tests.ML
{
    public class EMTest : TestBase
    {
        [Fact]
        public void TestEMCreate()
        {
            var em = EM.Create();
            var name = em.GetDefaultName();
            Assert.Equal(name, "opencv_ml_em");
        }
    }
}
