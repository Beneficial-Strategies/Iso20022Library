// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an mission allowance type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aa07AAnWEeWa7rBfPECYsw")]
[Description(@"Specifies an mission allowance type.")]
[DerivedFrom(typeof(AssetClassDetailedSubProductTypeCode))]
public enum EmissionAllowanceProductType1Code
{
    /// <summary>
    /// Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).
    /// Encoded/decoded by serializers as &quot;EUAA&quot;.
    /// </summary>
    [EnumMember(Value = "EUAA")]
    [IsoId("_e6j1sQnWEeWa7rBfPECYsw")]
    [Description(
        @"Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance)."
    )]
    EUAA = AssetClassDetailedSubProductTypeCode.EUAA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance EUA (European Union Allowance).
    /// Encoded/decoded by serializers as &quot;EUAE&quot;.
    /// </summary>
    [EnumMember(Value = "EUAE")]
    [IsoId("_fBs_gQnWEeWa7rBfPECYsw")]
    [Description(
        @"Commodity attribute of type emissions allowance EUA (European Union Allowance)."
    )]
    EUA = AssetClassDetailedSubProductTypeCode.EUA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance ERU (European Reduction Unit).
    /// Encoded/decoded by serializers as &quot;ERUE&quot;.
    /// </summary>
    [EnumMember(Value = "ERUE")]
    [IsoId("_fGweoQnWEeWa7rBfPECYsw")]
    [Description(@"Commodity attribute of type emissions allowance ERU (European Reduction Unit).")]
    ERU = AssetClassDetailedSubProductTypeCode.ERU, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance CER (Certified Emission Reduction).
    /// Encoded/decoded by serializers as &quot;CERE&quot;.
    /// </summary>
    [EnumMember(Value = "CERE")]
    [IsoId("_fL9uwQnWEeWa7rBfPECYsw")]
    [Description(
        @"Commodity attribute of type emissions allowance CER (Certified Emission Reduction)."
    )]
    CER = AssetClassDetailedSubProductTypeCode.CER, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_YQdvoX1uEeW6DpJJTspC5Q")]
    [Description(@"Commodity attribute of other type.")]
    Other = AssetClassDetailedSubProductTypeCode.Other, // same ordinal as derivation source for type conversions
}
