// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the calculation basis.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bVR0NNp-Ed-ak6NoX_4Aeg_-1828402497")]
[Description(@"Specifies the calculation basis.")]
[DerivedFrom(typeof(CalculationBasisCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CalculationBasis2Code>))]
#endif
public enum CalculationBasis2Code
{
    /// <summary>
    /// Average basis.
    /// Encoded/decoded by serializers as &quot;AVER&quot;.
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_bVR0Ndp-Ed-ak6NoX_4Aeg_-1779457837")]
    [Description(@"Average basis.")]
    Average = CalculationBasisCode.Average, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Daily basis.
    /// Encoded/decoded by serializers as &quot;DAIL&quot;.
    /// </summary>
    [EnumMember(Value = "DAIL")]
    [IsoId("_bVR0Ntp-Ed-ak6NoX_4Aeg_-1779457820")]
    [Description(@"Daily basis.")]
    Daily = CalculationBasisCode.Daily, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Monthly basis.
    /// Encoded/decoded by serializers as &quot;MNTH&quot;.
    /// </summary>
    [EnumMember(Value = "MNTH")]
    [IsoId("_bVR0N9p-Ed-ak6NoX_4Aeg_1334046994")]
    [Description(@"Monthly basis.")]
    Monthly = CalculationBasisCode.Monthly, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Yearly basis.
    /// Encoded/decoded by serializers as &quot;YEAR&quot;.
    /// </summary>
    [EnumMember(Value = "YEAR")]
    [IsoId("_bVR0ONp-Ed-ak6NoX_4Aeg_1334047012")]
    [Description(@"Yearly basis.")]
    Annual = CalculationBasisCode.Annual, // same ordinal as derivation source for type conversions
}
