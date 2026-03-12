// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading date code.
    /// </summary>
    [KnownType(typeof(TradingDateCode2Choice.Code))]
    [KnownType(typeof(TradingDateCode2Choice.Proprietary))]
    [JsonDerivedType(typeof(TradingDateCode2Choice.Code),nameof(TradingDateCode2Choice.Code))]
    [JsonDerivedType(typeof(TradingDateCode2Choice.Proprietary),nameof(TradingDateCode2Choice.Proprietary))]
    [IsoId("_DaQH5ZBhEeakHoV5BVecAQ")]
    [DisplayName("Trading Date Code 2 Choice")]
    public abstract partial record TradingDateCode2Choice_
    {
    }
}
