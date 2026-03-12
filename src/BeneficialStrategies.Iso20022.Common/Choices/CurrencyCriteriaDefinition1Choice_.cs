// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(CurrencyCriteriaDefinition1Choice.QueryName))]
    [KnownType(typeof(CurrencyCriteriaDefinition1Choice.NewCriteria))]
    [JsonDerivedType(typeof(CurrencyCriteriaDefinition1Choice.QueryName),nameof(CurrencyCriteriaDefinition1Choice.QueryName))]
    [JsonDerivedType(typeof(CurrencyCriteriaDefinition1Choice.NewCriteria),nameof(CurrencyCriteriaDefinition1Choice.NewCriteria))]
    [IsoId("_HxiIV5lZEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency Criteria Definition 1 Choice")]
    public abstract partial record CurrencyCriteriaDefinition1Choice_
    {
    }
}
