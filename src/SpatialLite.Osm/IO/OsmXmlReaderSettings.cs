﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpatialLite.Osm.IO {
	/// <summary>
	/// Contains settings that determine behaviour of the OsmXmlReader.
	/// </summary>
	public class OsmXmlReaderSettings : OsmReaderSettings {
		#region Private Fields

		private bool _strictMode = true;

		#endregion

		#region Public Properties

		/// <summary>
		/// Gets or sets a value indicating whether OsmXmlReader should run in strct mode.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Default value is true.
		/// </para>
		/// <para>
		/// In strict mode missing attributes for entity metadata causes OsmXmlReader to throw an exception. If strict mode is off and some metadata attributes are missing, missing attributes are set to their default values. 
		/// </para>
		/// </remarks>
		public bool StrictMode {
			get {
				return _strictMode;
			}
			set {
				if (this.IsReadOnly) {
					throw new InvalidOperationException("Cannot change the 'StrictMode' property - OsmXmlReaderSettings is read-only.");
				}

				_strictMode = value;
			}
		}

		#endregion
	}
}
