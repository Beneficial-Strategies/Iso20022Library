// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reporting of position or transaction for trade lifecycle events.
    /// </summary>
    [KnownType(typeof(TradeData58Choice.DataSetAction))]
    [KnownType(typeof(TradeData58Choice.State))]
    [JsonDerivedType(typeof(TradeData58Choice.DataSetAction),nameof(TradeData58Choice.DataSetAction))]
    [JsonDerivedType(typeof(TradeData58Choice.State),nameof(TradeData58Choice.State))]
    [IsoId("_B_8MQWEbEe2P-L9DBerEgA")]
    [DisplayName("Trade Data 58 Choice")]
    public abstract partial record TradeData58Choice_
    {
    }
}
