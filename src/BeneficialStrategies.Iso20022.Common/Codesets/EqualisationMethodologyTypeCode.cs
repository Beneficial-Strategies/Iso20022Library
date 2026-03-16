// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Methodology used for the allocation of the performance fees.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BkxvMBvkEe6BvtAMnhq3zw")]
[Description(@"Methodology used for the allocation of the performance fees.")]
[Derivations(typeof(EqualisationMethodologyType1Code))]
public enum EqualisationMethodologyTypeCode
{
    /// <summary>
    /// Mandatory redemption of units processed either at redemption or crystallization, whose proceeds are due to the asset manager as performance fee. Performance fee to be paid by the investor when the value of the investment fund units were below their applicable high-watermark on subscription date, and above the high-watermark on redemption date.
    /// Encoded/decoded by serializers as &quot;COLI&quot;.
    /// </summary>
    [EnumMember(Value = "COLI")]
    [IsoId("")]
    [Description(
        @"Mandatory redemption of units processed either at redemption or crystallization, whose proceeds are due to the asset manager as performance fee. Performance fee to be paid by the investor when the value of the investment fund units were below their applicable high-watermark on subscription date, and above the high-watermark on redemption date."
    )]
    ContingentLiquidation,

    /// <summary>
    /// Performance fee to be paid by the investor when the net asset value reaches the high-watermark if the net asset value was under the high-watermark on subscription date.
    /// Encoded/decoded by serializers as &quot;DDEP&quot;.
    /// </summary>
    [EnumMember(Value = "DDEP")]
    [IsoId("")]
    [Description(
        @"Performance fee to be paid by the investor when the net asset value reaches the high-watermark if the net asset value was under the high-watermark on subscription date."
    )]
    DepreciationDeposit,

    /// <summary>
    /// Prepayment amount to be paid by the investor at the moment of the subscription.  The amount is based on the positive difference between the gross asset value at subscription and the high-watermark, when the investment fund units are subscribed to above their high-watermark.
    /// Encoded/decoded by serializers as &quot;EQCR&quot;.
    /// </summary>
    [EnumMember(Value = "EQCR")]
    [IsoId("")]
    [Description(
        @"Prepayment amount to be paid by the investor at the moment of the subscription.  The amount is based on the positive difference between the gross asset value at subscription and the high-watermark, when the investment fund units are subscribed to above their high-watermark."
    )]
    EqualisationCredit,
}
