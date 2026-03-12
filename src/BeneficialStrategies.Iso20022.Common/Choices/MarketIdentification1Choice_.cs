// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of market identification.
    /// </summary>
    [KnownType(typeof(MarketIdentification1Choice.MarketIdentifierCode))]
    [KnownType(typeof(MarketIdentification1Choice.Description))]
    [JsonDerivedType(typeof(MarketIdentification1Choice.MarketIdentifierCode),nameof(MarketIdentification1Choice.MarketIdentifierCode))]
    [JsonDerivedType(typeof(MarketIdentification1Choice.Description),nameof(MarketIdentification1Choice.Description))]
    [IsoId("_Rctzptp-Ed-ak6NoX_4Aeg_-309699993")]
    [DisplayName("Market Identification 1 Choice")]
    public abstract partial record MarketIdentification1Choice_
    {
    }
}
