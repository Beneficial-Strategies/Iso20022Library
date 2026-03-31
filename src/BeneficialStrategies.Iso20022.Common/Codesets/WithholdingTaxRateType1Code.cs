// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of withholding tax rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y7v0kCeGEeOXAt_43VmZGw")]
[Description(@"Specifies the type of withholding tax rate.")]
[DerivedFrom(typeof(WithholdingTaxRateTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<WithholdingTaxRateType1Code>))]
#endif
public enum WithholdingTaxRateType1Code
{
    /// <summary>
    /// Withholding tax related to payments subject to back up withholding.
    /// Encoded/decoded by serializers as &quot;BWIT&quot;.
    /// </summary>
    [EnumMember(Value = "BWIT")]
    [IsoId("_dtVUQSeGEeOXAt_43VmZGw")]
    [Description(@"Withholding tax related to payments subject to back up withholding.")]
    BackUpWithholding = WithholdingTaxRateTypeCode.BackUpWithholding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withholding tax related to income subject to FATCA (Foreign Account Tax Compliance Act).
    /// Encoded/decoded by serializers as &quot;FTCA&quot;.
    /// </summary>
    [EnumMember(Value = "FTCA")]
    [IsoId("_d4CvcSeGEeOXAt_43VmZGw")]
    [Description(
        @"Withholding tax related to income subject to FATCA (Foreign Account Tax Compliance Act)."
    )]
    FATCATax = WithholdingTaxRateTypeCode.FATCATax, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withholding tax related to income subject to NRA (Non Resident Alien).
    /// Encoded/decoded by serializers as &quot;NRAT&quot;.
    /// </summary>
    [EnumMember(Value = "NRAT")]
    [IsoId("_d8qJsSeGEeOXAt_43VmZGw")]
    [Description(@"Withholding tax related to income subject to NRA (Non Resident Alien).")]
    NRATax = WithholdingTaxRateTypeCode.NRATax, // same ordinal as derivation source for type conversions
}
