// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for an investment need.
    /// </summary>
    [KnownType(typeof(InvestmentNeed2Choice.Code))]
    [KnownType(typeof(InvestmentNeed2Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestmentNeed2Choice.Code),nameof(InvestmentNeed2Choice.Code))]
    [JsonDerivedType(typeof(InvestmentNeed2Choice.Proprietary),nameof(InvestmentNeed2Choice.Proprietary))]
    [IsoId("_bO8yEaDtEequlaOyi6MUhw")]
    [DisplayName("Investment Need 2 Choice")]
    public abstract partial record InvestmentNeed2Choice_
    {
    }
}
