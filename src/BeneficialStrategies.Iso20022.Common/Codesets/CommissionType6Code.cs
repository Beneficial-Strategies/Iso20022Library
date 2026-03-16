// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of investment fund commission.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a_9rg9p-Ed-ak6NoX_4Aeg_2025119069")]
[Description(@"Specifies the type of investment fund commission.")]
[DerivedFrom(typeof(CommissionTypeV2Code))]
public enum CommissionType6Code
{
    /// <summary>
    /// Commission for subscribing to an investment, paid at the time of the subscription.
    /// Encoded/decoded by serializers as &quot;FEND&quot;.
    /// </summary>
    [EnumMember(Value = "FEND")]
    [IsoId("_a_9rhNp-Ed-ak6NoX_4Aeg_2072219495")]
    [Description(
        @"Commission for subscribing to an investment, paid at the time of the subscription."
    )]
    FrontEndLoad = CommissionTypeV2Code.FrontEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time.
    /// Encoded/decoded by serializers as &quot;BEND&quot;.
    /// </summary>
    [EnumMember(Value = "BEND")]
    [IsoId("_a_9rhdp-Ed-ak6NoX_4Aeg_2072219512")]
    [Description(
        @"Commission for redeeming an investment, when an investor redeems an investment fund within a certain period of time."
    )]
    BackEndLoad = CommissionTypeV2Code.BackEndLoad, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of cash due to an intermediary for selling a product, or services, to a third party.
    /// Encoded/decoded by serializers as &quot;CDPL&quot;.
    /// </summary>
    [EnumMember(Value = "CDPL")]
    [IsoId("_a_9rhtp-Ed-ak6NoX_4Aeg_22575918")]
    [Description(
        @"Amount of cash due to an intermediary for selling a product, or services, to a third party."
    )]
    CommissionDePlacement = CommissionTypeV2Code.CommissionDePlacement, // same ordinal as derivation source for type conversions
}
