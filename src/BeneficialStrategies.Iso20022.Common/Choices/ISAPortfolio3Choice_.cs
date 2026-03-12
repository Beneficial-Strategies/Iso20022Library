// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to provide additional portfolio information or individual savings account information (UK government scheme provided by UK based financial institutions only).
    /// </summary>
    [KnownType(typeof(ISAPortfolio3Choice.ISA))]
    [KnownType(typeof(ISAPortfolio3Choice.Portfolio))]
    [JsonDerivedType(typeof(ISAPortfolio3Choice.ISA),nameof(ISAPortfolio3Choice.ISA))]
    [JsonDerivedType(typeof(ISAPortfolio3Choice.Portfolio),nameof(ISAPortfolio3Choice.Portfolio))]
    [IsoId("_3fnhcEXfEeGY6MkiuzuPOA_-1372155354")]
    [DisplayName("ISA Portfolio 3 Choice")]
    public abstract partial record ISAPortfolio3Choice_
    {
    }
}
