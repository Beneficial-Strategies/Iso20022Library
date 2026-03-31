// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investment fund commission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_9rh9p-Ed-ak6NoX_4Aeg_1912267455")]
[Description(@"Specifies the type of investment fund commission.")]
[DerivedFrom(typeof(CommissionTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CommissionType7Code>))]
#endif
public enum CommissionType7Code
{
    /// <summary>
    /// Commission for subscribing to an investment, paid at the time of the subscription.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a_9riNp-Ed-ak6NoX_4Aeg_1912267481")]
    [Description(
        @"Commission for subscribing to an investment, paid at the time of the subscription."
    )]
    FrontEndLoad = CommissionTypeV2Code.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_bAHcgNp-Ed-ak6NoX_4Aeg_1912267490")]
    [Description(
        @"Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time."
    )]
    BackEndLoad = CommissionTypeV2Code.BackEndLoad, // same ordinal as derivation source for type conversions
}
