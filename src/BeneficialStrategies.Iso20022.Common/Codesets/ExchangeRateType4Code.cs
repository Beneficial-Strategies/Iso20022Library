// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code used to define the type of the currency exchange.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ExchangeRateType4Code")]
[Description(@"Code used to define the type of the currency exchange.")]
[DerivedFrom(typeof(ExchangeRateTypeCode))]
public enum ExchangeRateType4Code
{
    /// <summary>
    /// Exchange rate applied is the rate agreed between the parties.
    /// Encoded/decoded by serializers as &quot;AGRD&quot;.
    /// </summary>
    [EnumMember(Value = "AGRD")]
    [IsoId("_ExchangeRateType4Code_Agreed")]
    [Description(@"Exchange rate applied is the rate agreed between the parties.")]
    Agreed = ExchangeRateTypeCode.Agreed,

    /// <summary>
    /// Exchange rate applied is the market rate at the time of the sale.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_ExchangeRateType4Code_Sale")]
    [Description(@"Exchange rate applied is the market rate at the time of the sale.")]
    Sale = ExchangeRateTypeCode.Sale,

    /// <summary>
    /// Exchange rate applied is the spot rate.
    /// Encoded/decoded by serializers as &quot;SPOT&quot;.
    /// </summary>
    [EnumMember(Value = "SPOT")]
    [IsoId("_ExchangeRateType4Code_Spot")]
    [Description(@"Exchange rate applied is the spot rate.")]
    Spot = ExchangeRateTypeCode.Spot,
}
