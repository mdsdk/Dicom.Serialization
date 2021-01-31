﻿// Copyright (c) Robin Boerdijk - All rights reserved - See LICENSE file for license terms

namespace MDSDK.Dicom.Serialization.ValueRepresentations
{
    internal interface IHasLightWeightValueLengthCalculation<T>
    {
        long GetUnpaddedValueLength(T value);

        long GetUnpaddedValueLength(T[] values);
    }
}
