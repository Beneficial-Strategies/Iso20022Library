// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to provide additional portfolio information or individual savings account information (UK government scheme provided by UK based financial institutions only).
    /// </summary>
    [KnownType(typeof(ISAPortfolio1Choice.ISA))]
    [KnownType(typeof(ISAPortfolio1Choice.Portfolio))]
    [JsonDerivedType(typeof(ISAPortfolio1Choice.ISA),nameof(ISAPortfolio1Choice.ISA))]
    [JsonDerivedType(typeof(ISAPortfolio1Choice.Portfolio),nameof(ISAPortfolio1Choice.Portfolio))]
    [IsoId("_IjgyAENIEeGHJ_bHJRPaIQ_1207099058")]
    [DisplayName("ISA Portfolio 1 Choice")]
    public abstract partial record ISAPortfolio1Choice_
    {
    }
}
