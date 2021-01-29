﻿// Copyright (c) Robin Boerdijk - All rights reserved - See LICENSE file for license terms

namespace MDSDK.Dicom.Serialization.ValueRepresentations
{
    public sealed class LongString : SpecificCharsetEncodedMultiValue, IHas16BitExplicitVRLength
    {
        internal LongString() : base("LO") { }
    }
}
