// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of data set that is matched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VrxOA9p-Ed-ak6NoX_4Aeg_2082288743")]
[Description(@"Specifies the type of data set that is matched.")]
[DerivedFrom(typeof(DataSetTypeCode))]
public enum DataSetType1Code
{
    /// <summary>
    /// Data set is a baseline.
    /// Encoded/decoded by serializers as &quot;BASE&quot;.
    /// </summary>
    [EnumMember(Value = "BASE")]
    [IsoId("_VrxOBNp-Ed-ak6NoX_4Aeg_2126617722")]
    [Description(@"Data set is a baseline.")]
    Baseline = DataSetTypeCode.Baseline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set is a transport data set.
    /// Encoded/decoded by serializers as &quot;TRDS&quot;.
    /// </summary>
    [EnumMember(Value = "TRDS")]
    [IsoId("_VrxOBdp-Ed-ak6NoX_4Aeg_2126617739")]
    [Description(@"Data set is a transport data set.")]
    TransportDataSet = DataSetTypeCode.TransportDataSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set is a commercial data set.
    /// Encoded/decoded by serializers as &quot;CODS&quot;.
    /// </summary>
    [EnumMember(Value = "CODS")]
    [IsoId("_VrxOBtp-Ed-ak6NoX_4Aeg_2126617757")]
    [Description(@"Data set is a commercial data set.")]
    CommercialDataSet = DataSetTypeCode.CommercialDataSet, // same ordinal as derivation source for type conversions
}
