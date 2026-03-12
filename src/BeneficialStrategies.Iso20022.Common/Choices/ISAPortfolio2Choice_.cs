// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to provide additional portfolio information or individual savings account information (UK government scheme provided by UK based financial institutions only).
    /// </summary>
    [KnownType(typeof(ISAPortfolio2Choice.ISA))]
    [KnownType(typeof(ISAPortfolio2Choice.Portfolio))]
    [JsonDerivedType(typeof(ISAPortfolio2Choice.ISA),nameof(ISAPortfolio2Choice.ISA))]
    [JsonDerivedType(typeof(ISAPortfolio2Choice.Portfolio),nameof(ISAPortfolio2Choice.Portfolio))]
    [IsoId("_3fnhckXfEeGY6MkiuzuPOA_858119227")]
    [DisplayName("ISA Portfolio 2 Choice")]
    public abstract partial record ISAPortfolio2Choice_
    {
    }
}
