// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the rate of tax levied.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zFFVsA2YEeSNWNtJlXOAhg")]
[Description(@"Specifies the rate of tax levied.")]
[DerivedFrom(typeof(TaxRateMarkerCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxRateMarker1Code>))]
#endif
public enum TaxRateMarker1Code
{
    /// <summary>
    /// Specifies the amount quoted less life assurance premium rate income tax.
    /// Encoded/decoded by serializers as &quot;ALPR&quot;.
    /// </summary>
    [EnumMember(Value = "ALPR")]
    [IsoId("_z5l70Q2YEeSNWNtJlXOAhg")]
    [Description(@"Specifies the amount quoted less life assurance premium rate income tax.")]
    AmountQuotedLessLifeAssurance = TaxRateMarkerCode.AmountQuotedLessLifeAssurance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the amount quoted less standard rate income tax.
    /// Encoded/decoded by serializers as &quot;ALIT&quot;.
    /// </summary>
    [EnumMember(Value = "ALIT")]
    [IsoId("_z-DlEQ2YEeSNWNtJlXOAhg")]
    [Description(@"Specifies the amount quoted less standard rate income tax.")]
    AmountQuotedLessStandardRate = TaxRateMarkerCode.AmountQuotedLessStandardRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies an amount before the deduction of tax.
    /// Encoded/decoded by serializers as &quot;GRSS&quot;.
    /// </summary>
    [EnumMember(Value = "GRSS")]
    [IsoId("_0Cq_UQ2YEeSNWNtJlXOAhg")]
    [Description(@"Specifies an amount before the deduction of tax.")]
    GrossAmount = TaxRateMarkerCode.GrossAmount, // same ordinal as derivation source for type conversions
}
