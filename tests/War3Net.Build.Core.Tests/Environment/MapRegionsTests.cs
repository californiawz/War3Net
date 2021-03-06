﻿// ------------------------------------------------------------------------------
// <copyright file="MapRegionsTests.cs" company="Drake53">
// Licensed under the MIT license.
// See the LICENSE file in the project root for more information.
// </copyright>
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using War3Net.Build.Environment;
using War3Net.Common.Testing;
using War3Net.IO.Mpq;

namespace War3Net.Build.Core.Tests.Environment
{
    [TestClass]
    public class MapRegionsTests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetRegionFiles), DynamicDataSourceType.Method)]
        public void TestParseMapRegions(string regionsFilePath)
        {
            using var original = FileProvider.GetFile(regionsFilePath);
            using var recreated = new MemoryStream();

            MapRegions.Parse(original, true).SerializeTo(recreated, true);
            StreamAssert.AreEqual(original, recreated, true);
        }

        private static IEnumerable<object[]> GetRegionFiles()
        {
            return TestDataProvider.GetDynamicData(
                MapRegions.FileName.GetSearchPattern(),
                SearchOption.AllDirectories,
                Path.Combine("Region"))

            .Concat(TestDataProvider.GetDynamicArchiveData(
                MapRegions.FileName,
                SearchOption.TopDirectoryOnly,
                "Maps"));
        }
    }
}