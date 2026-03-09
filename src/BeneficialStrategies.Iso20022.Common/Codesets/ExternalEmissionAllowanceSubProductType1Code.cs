// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the detailed sub products types allowed for emission allowances and associated derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sb74IG8wEe6_0L6gLGEkbA")]
[Description(@"Specifies the detailed sub products types allowed for emission allowances and associated derivatives.")]
[DerivedFrom(typeof(ExternalEmissionAllowanceSubProductTypeCode))]
public enum ExternalEmissionAllowanceSubProductType1Code
{
    /// <summary>
    /// Commodity attribute of type emissions allowance CER (Certified Emission Reduction).
    /// Encoded/decoded by serializers as &quot;CERE&quot;.
    /// </summary>
    [EnumMember(Value = "CERE")]
    [IsoId("")]
    [Description(@"Commodity attribute of type emissions allowance CER (Certified Emission Reduction).")]
    CER = ExternalEmissionAllowanceSubProductTypeCode.CER, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance ERU (European Reduction Unit).
    /// Encoded/decoded by serializers as &quot;ERUE&quot;.
    /// </summary>
    [EnumMember(Value = "ERUE")]
    [IsoId("")]
    [Description(@"Commodity attribute of type emissions allowance ERU (European Reduction Unit).")]
    ERU = ExternalEmissionAllowanceSubProductTypeCode.ERU, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).
    /// Encoded/decoded by serializers as &quot;EUAA&quot;.
    /// </summary>
    [EnumMember(Value = "EUAA")]
    [IsoId("")]
    [Description(@"Commodity attribute of type emissions allowance EUAA (European Union Aviation Allowance).")]
    EUAA = ExternalEmissionAllowanceSubProductTypeCode.EUAA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of type emissions allowance EUA (European Union Allowance).
    /// Encoded/decoded by serializers as &quot;EUAE&quot;.
    /// </summary>
    [EnumMember(Value = "EUAE")]
    [IsoId("")]
    [Description(@"Commodity attribute of type emissions allowance EUA (European Union Allowance).")]
    EUA = ExternalEmissionAllowanceSubProductTypeCode.EUA, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commodity attribute of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("")]
    [Description(@"Commodity attribute of other type.")]
    Other = ExternalEmissionAllowanceSubProductTypeCode.Other, // same ordinal as derivation source for type conversions

}
