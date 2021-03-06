// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using BuildXL.ToolSupport;
using Xunit;

namespace Test.BuildXL.ToolSupport
{
    public class ToolOptionPrinting
    {
        [Fact]
        public void ReconstructArgumentWithJustName()
        {
            var result = new CommandLineUtilities.Option() { Name = "name" }.PrintCommandLineString();
            Assert.Equal("/name", result);
        }

        [Fact]
        public void ReconstructArgumentWithNameAndValue()
        {
            var result = new CommandLineUtilities.Option() { Name = "name", Value = "value" }.PrintCommandLineString();
            Assert.Equal("/name:value", result);
        }

        [Fact]
        public void ReconstructArgumentWithNameAndValueWithSpace()
        {
            var result = new CommandLineUtilities.Option() { Name = "name", Value = "value value" }.PrintCommandLineString();
            Assert.Equal("/name:\"value value\"", result);
        }

        [Fact]
        public void ReconstructArgumentWithNameAndValueWithQuote()
        {
            var result = new CommandLineUtilities.Option() { Name = "name", Value = "value\"value" }.PrintCommandLineString();
            Assert.Equal("/name:value\\\"value", result);
        }

        [Fact]
        public void ReconstructArgumentWithNameAndValueWithSpaceAndQuote()
        {
            var result = new CommandLineUtilities.Option() { Name = "name", Value = "value value\"value" }.PrintCommandLineString();
            Assert.Equal("/name:\"value value\\\"value\"", result);
        }
    }
}
