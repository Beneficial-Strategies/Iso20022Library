// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of data set that is matched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayG1stp-Ed-ak6NoX_4Aeg_597609092")]
[Description(@"Specifies the type of data set that is matched.")]
[DerivedFrom(typeof(DataSetTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DataSetType2Code>))]
#endif
public enum DataSetType2Code
{
    /// <summary>
    /// Data set is a baseline.
    /// Encoded/decoded by serializers as &quot;BASE&quot;.
    /// </summary>
    [EnumMember(Value = "BASE")]
    [IsoId("_ayG1s9p-Ed-ak6NoX_4Aeg_597609124")]
    [Description(@"Data set is a baseline.")]
    Baseline = DataSetTypeCode.Baseline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set is a transport data set.
    /// Encoded/decoded by serializers as &quot;TRDS&quot;.
    /// </summary>
    [EnumMember(Value = "TRDS")]
    [IsoId("_ayG1tNp-Ed-ak6NoX_4Aeg_597609125")]
    [Description(@"Data set is a transport data set.")]
    TransportDataSet = DataSetTypeCode.TransportDataSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set is a commercial data set.
    /// Encoded/decoded by serializers as &quot;CODS&quot;.
    /// </summary>
    [EnumMember(Value = "CODS")]
    [IsoId("_ayG1tdp-Ed-ak6NoX_4Aeg_597609154")]
    [Description(@"Data set is a commercial data set.")]
    CommercialDataSet = DataSetTypeCode.CommercialDataSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set is an insurance data set.
    /// Encoded/decoded by serializers as &quot;INDS&quot;.
    /// </summary>
    [EnumMember(Value = "INDS")]
    [IsoId("_ayG1ttp-Ed-ak6NoX_4Aeg_672416869")]
    [Description(@"Data set is an insurance data set.")]
    InsuranceDataSet = DataSetTypeCode.InsuranceDataSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set is a certificate data set.
    /// Encoded/decoded by serializers as &quot;CEDS&quot;.
    /// </summary>
    [EnumMember(Value = "CEDS")]
    [IsoId("_ayG1t9p-Ed-ak6NoX_4Aeg_925458258")]
    [Description(@"Data set is a certificate data set.")]
    CertificateDataSet = DataSetTypeCode.CertificateDataSet, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data set is an other special certificate data set.
    /// Encoded/decoded by serializers as &quot;OCDS&quot;.
    /// </summary>
    [EnumMember(Value = "OCDS")]
    [IsoId("_ayG1uNp-Ed-ak6NoX_4Aeg_940237322")]
    [Description(@"Data set is an other special certificate data set.")]
    OtherCertificateDataSet = DataSetTypeCode.OtherCertificateDataSet, // same ordinal as derivation source for type conversions
}
