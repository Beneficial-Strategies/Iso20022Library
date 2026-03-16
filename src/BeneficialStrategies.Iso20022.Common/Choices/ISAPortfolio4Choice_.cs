// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between individual savings account information or additional portfolio information.
    /// </summary>
    [KnownType(typeof(ISAPortfolio4Choice.ISA))]
    [KnownType(typeof(ISAPortfolio4Choice.Portfolio))]
    [JsonDerivedType(typeof(ISAPortfolio4Choice.ISA), nameof(ISAPortfolio4Choice.ISA))]
    [JsonDerivedType(typeof(ISAPortfolio4Choice.Portfolio), nameof(ISAPortfolio4Choice.Portfolio))]
    [IsoId("_0xR5cbNBEeewUI7-Tnew9A")]
    [DisplayName("ISA Portfolio 4 Choice")]
    public abstract record ISAPortfolio4Choice_ { }
}
