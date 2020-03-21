﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NGrib.Sections;

namespace NGrib
{
	public class Grib2Reader
	{
		private readonly Stream gribStream;
		private BufferedBinaryReader reader;

		public Grib2Reader(Stream gribStream)
		{
			this.gribStream = gribStream;
			reader = new BufferedBinaryReader(gribStream, 4096);
		}

		private void MapGrib()
		{
			var indicatorSection = Grib2IndicatorSection.BuildFrom(reader);
		}
	}
}
