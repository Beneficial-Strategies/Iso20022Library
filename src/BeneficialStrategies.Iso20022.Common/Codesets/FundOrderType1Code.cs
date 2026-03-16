// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the investment fund order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_atCvgdp-Ed-ak6NoX_4Aeg_1585971671")]
[Description(@"Specifies the type of the investment fund order.")]
[DerivedFrom(typeof(FundOrderTypeCode))]
public enum FundOrderType1Code
{
    /// <summary>
    /// Investment fund order is a subscription.
    /// Encoded/decoded by serializers as &quot;SUBS&quot;.
    /// </summary>
    [EnumMember(Value = "SUBS")]
    [IsoId("_atCvgtp-Ed-ak6NoX_4Aeg_1645076282")]
    [Description(@"Investment fund order is a subscription.")]
    Subscription = FundOrderTypeCode.Subscription, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a redemption.
    /// Encoded/decoded by serializers as &quot;REDM&quot;.
    /// </summary>
    [EnumMember(Value = "REDM")]
    [IsoId("_atCvg9p-Ed-ak6NoX_4Aeg_1645076559")]
    [Description(@"Investment fund order is a redemption.")]
    Redemption = FundOrderTypeCode.Redemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment fund order is a switch.
    /// Encoded/decoded by serializers as &quot;SWIT&quot;.
    /// </summary>
    [EnumMember(Value = "SWIT")]
    [IsoId("_atCvhNp-Ed-ak6NoX_4Aeg_1645076612")]
    [Description(@"Investment fund order is a switch.")]
    Switch = FundOrderTypeCode.Switch, // same ordinal as derivation source for type conversions
}
