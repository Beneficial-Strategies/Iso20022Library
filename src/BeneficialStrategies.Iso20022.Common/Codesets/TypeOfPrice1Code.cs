// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of price and information about the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yx9i5dp-Ed-ak6NoX_4Aeg_-1302250885")]
[Description(@"Specifies the type of price and information about the price.")]
[DerivedFrom(typeof(TypeOfPriceCode))]
public enum TypeOfPrice1Code
{
    /// <summary>
    /// Price is an average execution price.
    /// Encoded/decoded by serializers as &quot;AVER&quot;.
    /// </summary>
    [EnumMember(Value = "AVER")]
    [IsoId("_Yx9i5tp-Ed-ak6NoX_4Aeg_-960547282")]
    [Description(@"Price is an average execution price.")]
    Average = TypeOfPriceCode.Average, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is an override of the average price.
    /// Encoded/decoded by serializers as &quot;AVOV&quot;.
    /// </summary>
    [EnumMember(Value = "AVOV")]
    [IsoId("_Yx9i59p-Ed-ak6NoX_4Aeg_-960547190")]
    [Description(@"Price is an override of the average price.")]
    AverageOverride = TypeOfPriceCode.AverageOverride, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is composed of the combined expenses (used in the UK market).
    /// Encoded/decoded by serializers as &quot;COMB&quot;.
    /// </summary>
    [EnumMember(Value = "COMB")]
    [IsoId("_Yx9i6Np-Ed-ak6NoX_4Aeg_-960547129")]
    [Description(@"Price is composed of the combined expenses (used in the UK market).")]
    Combined = TypeOfPriceCode.Combined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is a gross execution price. The price is an all inclusive price, ie, including all charges, fees, and taxes.
    /// Encoded/decoded by serializers as &quot;GREX&quot;.
    /// </summary>
    [EnumMember(Value = "GREX")]
    [IsoId("_YyGs0Np-Ed-ak6NoX_4Aeg_-960547015")]
    [Description(@"Price is a gross execution price. The price is an all inclusive price, ie, including all charges, fees, and taxes.")]
    GrossOfAll = TypeOfPriceCode.GrossOfAll, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is the limit price of a limit order, eg, a customer might put in a limit order to sell financial instruments at 67 or to buy at 60.
    /// Encoded/decoded by serializers as &quot;LIMI&quot;.
    /// </summary>
    [EnumMember(Value = "LIMI")]
    [IsoId("_YyGs0dp-Ed-ak6NoX_4Aeg_-960546706")]
    [Description(@"Price is the limit price of a limit order, eg, a customer might put in a limit order to sell financial instruments at 67 or to buy at 60.")]
    Limit = TypeOfPriceCode.Limit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is a net price, ie, net only of local broker&apos;s commission, local fees and local taxes.
    /// Encoded/decoded by serializers as &quot;NET2&quot;.
    /// </summary>
    [EnumMember(Value = "NET2")]
    [IsoId("_YyGs0tp-Ed-ak6NoX_4Aeg_-960546614")]
    [Description(@"Price is a net price, ie, net only of local broker's commission, local fees and local taxes.")]
    Net = TypeOfPriceCode.Net, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is net to the disclosed client.
    /// Encoded/decoded by serializers as &quot;NDIS&quot;.
    /// </summary>
    [EnumMember(Value = "NDIS")]
    [IsoId("_YyGs09p-Ed-ak6NoX_4Aeg_-960546274")]
    [Description(@"Price is net to the disclosed client.")]
    NetDisclosed = TypeOfPriceCode.NetDisclosed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is a net price, ie, net of all charges, fees and taxes.
    /// Encoded/decoded by serializers as &quot;NET1&quot;.
    /// </summary>
    [EnumMember(Value = "NET1")]
    [IsoId("_YyGs1Np-Ed-ak6NoX_4Aeg_-960546182")]
    [Description(@"Price is a net price, ie, net of all charges, fees and taxes.")]
    NetOfAll = TypeOfPriceCode.NetOfAll, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is net to the client undisclosed (used in the UK market).
    /// Encoded/decoded by serializers as &quot;NUND&quot;.
    /// </summary>
    [EnumMember(Value = "NUND")]
    [IsoId("_YyGs1dp-Ed-ak6NoX_4Aeg_-960546090")]
    [Description(@"Price is net to the client undisclosed (used in the UK market).")]
    NetUndisclosed = TypeOfPriceCode.NetUndisclosed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is notional gross (used in the UK market).
    /// Encoded/decoded by serializers as &quot;NOGR&quot;.
    /// </summary>
    [EnumMember(Value = "NOGR")]
    [IsoId("_YyGs1tp-Ed-ak6NoX_4Aeg_-960545758")]
    [Description(@"Price is notional gross (used in the UK market).")]
    NotionalGross = TypeOfPriceCode.NotionalGross, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is equal to the nominal or face value of the instrument.
    /// Encoded/decoded by serializers as &quot;PARV&quot;.
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_YyGs19p-Ed-ak6NoX_4Aeg_-959625664")]
    [Description(@"Price is equal to the nominal or face value of the instrument.")]
    ParValue = TypeOfPriceCode.ParValue, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is a rounded average price.
    /// Encoded/decoded by serializers as &quot;RDAV&quot;.
    /// </summary>
    [EnumMember(Value = "RDAV")]
    [IsoId("_YyGs2Np-Ed-ak6NoX_4Aeg_-959625572")]
    [Description(@"Price is a rounded average price.")]
    RoundedAverage = TypeOfPriceCode.RoundedAverage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Price is a stop price used in an order to buy. The order becomes a market order when the financial instrument trades at or above the stop price after the order is submitted. In an order to sell the order becomes a market order when the financial instrument trades at or below the stop price.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_YyQd0Np-Ed-ak6NoX_4Aeg_-959625450")]
    [Description(@"Price is a stop price used in an order to buy. The order becomes a market order when the financial instrument trades at or above the stop price after the order is submitted. In an order to sell the order becomes a market order when the financial instrument trades at or below the stop price.")]
    Stop = TypeOfPriceCode.Stop, // same ordinal as derivation source for type conversions
    
}
