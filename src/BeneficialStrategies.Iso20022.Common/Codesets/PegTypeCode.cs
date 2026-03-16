// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates a type of instruction to a broker/dealer to buy or sell a financial instrument which is pegged against a certain value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z9zq9dp-Ed-ak6NoX_4Aeg_-765699713")]
[Description(
    @"Indicates a type of instruction to a broker/dealer to buy or sell a financial instrument which is pegged against a certain value."
)]
[Derivations(typeof(PegType1Code))]
public enum PegTypeCode
{
    /// <summary>
    /// Order pegged against a fixed amount (local best bid or offer, at time of order).
    /// Encoded/decoded by serializers as &quot;FIXE&quot;.
    /// </summary>
    [EnumMember(Value = "FIXE")]
    [IsoId("_Z9zq9tp-Ed-ak6NoX_4Aeg_396098933")]
    [Description(
        @"Order pegged against a fixed amount (local best bid or offer, at time of order)."
    )]
    Fixed,

    /// <summary>
    /// Order pegged against the last price.
    /// Encoded/decoded by serializers as &quot;LAST&quot;.
    /// </summary>
    [EnumMember(Value = "LAST")]
    [IsoId("_Z9zq99p-Ed-ak6NoX_4Aeg_396098975")]
    [Description(@"Order pegged against the last price.")]
    Last,

    /// <summary>
    /// Order pegged against the current market price. Relative to the offering if buying and relative to the bid if selling.
    /// Encoded/decoded by serializers as &quot;MARK&quot;.
    /// </summary>
    [EnumMember(Value = "MARK")]
    [IsoId("_Z9zq-Np-Ed-ak6NoX_4Aeg_396099018")]
    [Description(
        @"Order pegged against the current market price. Relative to the offering if buying and relative to the bid if selling."
    )]
    Market,

    /// <summary>
    /// Order pegged against the mid price, which is the average between the offer and bid prices.
    /// Encoded/decoded by serializers as &quot;MIDP&quot;.
    /// </summary>
    [EnumMember(Value = "MIDP")]
    [IsoId("_Z9804Np-Ed-ak6NoX_4Aeg_396099053")]
    [Description(
        @"Order pegged against the mid price, which is the average between the offer and bid prices."
    )]
    MidPrice,

    /// <summary>
    /// Order pegged against the opening price.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_Z9804dp-Ed-ak6NoX_4Aeg_396099088")]
    [Description(@"Order pegged against the opening price.")]
    Opening,

    /// <summary>
    /// Order pegged against the primary market where the financial instrument is traded. It is relative to the offering if buying and relative to the bid if selling.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_Z9804tp-Ed-ak6NoX_4Aeg_396099347")]
    [Description(
        @"Order pegged against the primary market where the financial instrument is traded. It is relative to the offering if buying and relative to the bid if selling."
    )]
    Primary,

    /// <summary>
    /// Order pegged against the volume weighted average price for the day.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_Z98049p-Ed-ak6NoX_4Aeg_396099390")]
    [Description(@"Order pegged against the volume weighted average price for the day.")]
    VolumeWeightAveragePrice,

    /// <summary>
    /// Pegged order representing a stop order with a stop price pegged to trail a specified distance behind the last price. The price of a trailing stop to buy can never increase, and the price of a trailing stop to sell can never decrease.
    /// Encoded/decoded by serializers as &quot;TRST&quot;.
    /// </summary>
    [EnumMember(Value = "TRST")]
    [IsoId("_Z9805Np-Ed-ak6NoX_4Aeg_421956459")]
    [Description(
        @"Pegged order representing a stop order with a stop price pegged to trail a specified distance behind the last price. The price of a trailing stop to buy can never increase, and the price of a trailing stop to sell can never decrease."
    )]
    TrailingStop,

    /// <summary>
    /// Order pegged against a limit price.
    /// Encoded/decoded by serializers as &quot;LIMI&quot;.
    /// </summary>
    [EnumMember(Value = "LIMI")]
    [IsoId("_Z-Gl4Np-Ed-ak6NoX_4Aeg_437656943")]
    [Description(@"Order pegged against a limit price.")]
    LimitPrice,
}
