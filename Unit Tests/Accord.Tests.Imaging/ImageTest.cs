// Copyright © César Souza, 2009-2017
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Imaging.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using AForge;
    using Accord.Imaging;
    using NUnit.Framework;
    using Accord.DataSets;
    using Accord.Tests.Imaging.Properties;
#if NO_BITMAP
    using Resources = Accord.Tests.Imaging.Properties.Resources_Standard;
#endif

    [TestFixture]
    public class ImageTest
    {
        [Test]
        public void load_true_grayscale_test()
        {
            Bitmap lena2 = Accord.Imaging.Image.Clone(Resources.lena512);

            Assert.IsTrue(lena2.IsGrayscale());

            int max2 = lena2.Max();

            int min2 = lena2.Min();

            Assert.AreEqual(245, max2);
            Assert.AreEqual(25, min2);
        }

        [Test]
        public void test_images_test()
        {
            Bitmap lena = Resources.lena512;

            Assert.IsTrue(lena.IsGrayscale());
        }
    }
}
