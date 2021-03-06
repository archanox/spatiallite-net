﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpatialLite.Gps.IO {
    /// <summary>
    /// Contains settings that determine behaviour of GpxReader.
    /// </summary>
    public class GpxReaderSettings {
        #region Private Fields

		bool _readMetadata = true;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GpxReaderSettings class with default values.
		/// </summary>
		public GpxReaderSettings() {
			this.ReadMetadata = true;
		}

		#endregion

		#region Public Properties

		/// <summary>
		/// Gets a value indicating whether GpxReader should read and parse metadata.
		/// </summary>
		public bool ReadMetadata {
			get {
				return _readMetadata;
			}
			set {
				if (this.IsReadOnly) {
					throw new InvalidOperationException("Cannot change the 'ReadMetadata' property GpxReaderSettings is read-only.");
				}

				_readMetadata = value;
			}
		}

		/// <summary>
		/// Gets or sets value indicating whether properties of the current GpxReaderSettings instance can be changed.
		/// </summary>
		protected internal bool IsReadOnly { get; internal set; }

		#endregion
    }
}
