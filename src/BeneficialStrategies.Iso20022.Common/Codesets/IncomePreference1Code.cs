// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the options for distribution of dividend income.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aV8eJ9p-Ed-ak6NoX_4Aeg_-254456777")]
[Description(@"Specifies the options for distribution of dividend income.")]
[DerivedFrom(typeof(IncomePreferenceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<IncomePreference1Code>))]
#endif
public enum IncomePreference1Code
{
    /// <summary>
    /// Distribution in cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_aV8eKNp-Ed-ak6NoX_4Aeg_-1613438305")]
    [Description(@"Distribution in cash.")]
    Cash = IncomePreferenceCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reinvestment of proceeds into securities.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_aWGPINp-Ed-ak6NoX_4Aeg_-1601434888")]
    [Description(@"Reinvestment of proceeds into securities.")]
    DividendReinvestment = IncomePreferenceCode.DividendReinvestment, // same ordinal as derivation source for type conversions
}
