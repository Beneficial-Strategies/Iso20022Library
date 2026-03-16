// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates a type of instruction to a broker or dealer to buy or sell a financial instrument which is pegged against a certain value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z9p599p-Ed-ak6NoX_4Aeg_307440382")]
[Description(
    @"Indicates a type of instruction to a broker or dealer to buy or sell a financial instrument which is pegged against a certain value."
)]
[DerivedFrom(typeof(PegTypeCode))]
public enum PegType1Code
{
    /// <summary>
    /// Order pegged against a fixed amount (local best bid or offer, at time of order).
    /// Encoded/decoded by serializers as &quot;FIXE&quot;.
    /// </summary>
    [EnumMember(Value = "FIXE")]
    [IsoId("_Z9p5-Np-Ed-ak6NoX_4Aeg_307440399")]
    [Description(
        @"Order pegged against a fixed amount (local best bid or offer, at time of order)."
    )]
    Fixed = PegTypeCode.Fixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order pegged against the last price.
    /// Encoded/decoded by serializers as &quot;LAST&quot;.
    /// </summary>
    [EnumMember(Value = "LAST")]
    [IsoId("_Z9p5-dp-Ed-ak6NoX_4Aeg_307440417")]
    [Description(@"Order pegged against the last price.")]
    Last = PegTypeCode.Last, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order pegged against the current market price. Relative to the offering if buying and relative to the bid if selling.
    /// Encoded/decoded by serializers as &quot;MARK&quot;.
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_Z9zq8Np-Ed-ak6NoX_4Aeg_307440434")]
    [Description(
        @"Order pegged against the current market price. Relative to the offering if buying and relative to the bid if selling."
    )]
    Market = PegTypeCode.Market, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order pegged against the mid price, which is the average between the offer and bid prices.
    /// Encoded/decoded by serializers as &quot;MIDP&quot;.
    /// </summary>
    [EnumMember(Value = "MIDP")]
    [IsoId("_Z9zq8dp-Ed-ak6NoX_4Aeg_307440452")]
    [Description(
        @"Order pegged against the mid price, which is the average between the offer and bid prices."
    )]
    MidPrice = PegTypeCode.MidPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order pegged against the opening price.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_Z9zq8tp-Ed-ak6NoX_4Aeg_307440477")]
    [Description(@"Order pegged against the opening price.")]
    Opening = PegTypeCode.Opening, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order pegged against the primary market where the financial instrument is traded. It is relative to the offering if buying and relative to the bid if selling.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_Z9zq89p-Ed-ak6NoX_4Aeg_307440494")]
    [Description(
        @"Order pegged against the primary market where the financial instrument is traded. It is relative to the offering if buying and relative to the bid if selling."
    )]
    Primary = PegTypeCode.Primary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order pegged against the volume weighted average price for the day.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_Z9zq9Np-Ed-ak6NoX_4Aeg_307440512")]
    [Description(@"Order pegged against the volume weighted average price for the day.")]
    VolumeWeightAveragePrice = PegTypeCode.VolumeWeightAveragePrice, // same ordinal as derivation source for type conversions
}
