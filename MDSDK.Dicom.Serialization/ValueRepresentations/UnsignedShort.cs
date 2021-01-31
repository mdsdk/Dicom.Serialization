﻿// Copyright (c) Robin Boerdijk - All rights reserved - See LICENSE file for license terms

using System;

namespace MDSDK.Dicom.Serialization.ValueRepresentations
{
    public class UnsignedShort : BinaryEncodedPrimitiveValue<UInt16>, IHas16BitExplicitVRLength
    {
        public UnsignedShort() : base("US") { }
    }
}
