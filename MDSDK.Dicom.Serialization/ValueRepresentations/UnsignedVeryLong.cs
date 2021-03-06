﻿// Copyright (c) Robin Boerdijk - All rights reserved - See LICENSE file for license terms

using System;

namespace MDSDK.Dicom.Serialization.ValueRepresentations
{
    public class UnsignedVeryLong : BinaryEncodedPrimitiveValue<UInt64>, IHas32BitExplicitVRLength
    {
        public UnsignedVeryLong() : base("UV") { }
    }
}
