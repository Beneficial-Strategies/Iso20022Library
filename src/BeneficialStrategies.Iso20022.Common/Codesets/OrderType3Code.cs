// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of instruction to a broker or dealer to buy or sell a financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uqej8GzBEe23cotbkl38pw")]
[Description(
    @"Specifies the type of instruction to a broker or dealer to buy or sell a financial instrument."
)]
[DerivedFrom(typeof(OrderTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OrderType3Code>))]
public enum OrderType3Code
{
    /// <summary>
    /// An order to buy at the indicated price limit or lower or an order to sell at the indicated limit price or higher.
    /// Encoded/decoded by serializers as &quot;LMTO&quot;.
    /// </summary>
    [EnumMember(Value = "LMTO")]
    [IsoId("_vyCo8WzBEe23cotbkl38pw")]
    [Description(
        @"An order to buy at the indicated price limit or lower or an order to sell at the indicated limit price or higher."
    )]
    Limit = OrderTypeCode.Limit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An order to buy which becomes a market order when the financial instrument trades at or above the stop price after the order is submitted or an order to sell which becomes a market order when the financial instrument trades at or below the stop price after the order is submitted.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_x71nAWzBEe23cotbkl38pw")]
    [Description(
        @"An order to buy which becomes a market order when the financial instrument trades at or above the stop price after the order is submitted or an order to sell which becomes a market order when the financial instrument trades at or below the stop price after the order is submitted."
    )]
    Stop = OrderTypeCode.Stop, // same ordinal as derivation source for type conversions
}
