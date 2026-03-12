// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType8Choice.Code))]
    [KnownType(typeof(MarketType8Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType8Choice.Code),nameof(MarketType8Choice.Code))]
    [JsonDerivedType(typeof(MarketType8Choice.Proprietary),nameof(MarketType8Choice.Proprietary))]
    [IsoId("_Ql4SQtp-Ed-ak6NoX_4Aeg_1045554562")]
    [DisplayName("Market Type 8 Choice")]
    public abstract partial record MarketType8Choice_
    {
    }
}
