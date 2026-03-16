// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code used to define the type of the currency exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ak11w9p-Ed-ak6NoX_4Aeg_-83850044")]
[Description(@"Code used to define the type of the currency exchange.")]
[Derivations(typeof(ExchangeRateType1Code), typeof(ExchangeRateType2Code))]
public enum ExchangeRateTypeCode
{
    /// <summary>
    /// Exchange rate applied is the spot rate.
    /// Encoded/decoded by serializers as &quot;SPOT&quot;.
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_ak11xNp-Ed-ak6NoX_4Aeg_-83849440")]
    [Description(@"Exchange rate applied is the spot rate.")]
    Spot,

    /// <summary>
    /// Exchange rate applied is the market rate at the time of the sale.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_ak11xdp-Ed-ak6NoX_4Aeg_-83848510")]
    [Description(@"Exchange rate applied is the market rate at the time of the sale.")]
    Sale,

    /// <summary>
    /// Exchange rate applied is the rate agreed between the parties.
    /// Encoded/decoded by serializers as &quot;AGRD&quot;.
    /// </summary>
    [EnumMember(Value = "AGRD")]
    [IsoId("_ak11xtp-Ed-ak6NoX_4Aeg_-83848149")]
    [Description(@"Exchange rate applied is the rate agreed between the parties.")]
    Agreed,

    /// <summary>
    /// Exchange rate is the Buy rate.
    /// Encoded/decoded by serializers as &quot;BUYR&quot;.
    /// </summary>
    [EnumMember(Value = "BUYR")]
    [IsoId("_vajHsIZ2Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Buy rate.")]
    Buy,

    /// <summary>
    /// Exchange rate is the Sell rate.
    /// Encoded/decoded by serializers as &quot;SELL&quot;.
    /// </summary>
    [EnumMember(Value = "SELL")]
    [IsoId("_6jX2QIZ2Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Sell rate.")]
    Sell,

    /// <summary>
    /// Exchange rate is the Middle rate.
    /// Encoded/decoded by serializers as &quot;MIDL&quot;.
    /// </summary>
    [EnumMember(Value = "MIDL")]
    [IsoId("__iusMIZ2Eeufof77RM8ObQ")]
    [Description(@"Exchange rate is the Middle rate.")]
    Middle,

    /// <summary>
    /// Exchange rate type that is defined at the National level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_EZzI0IZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate type that is defined at the National level.")]
    OtherNational,

    /// <summary>
    /// Exchange rate type is privately defined.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_MQHk0IZ3Eeufof77RM8ObQ")]
    [Description(@"Exchange rate type is privately defined.")]
    OtherPrivate,
}
