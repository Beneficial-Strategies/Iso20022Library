// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(CurrencyCriteria1Choice.QueryName))]
    [KnownType(typeof(CurrencyCriteria1Choice.NewCriteria))]
    [JsonDerivedType(typeof(CurrencyCriteria1Choice.QueryName),nameof(CurrencyCriteria1Choice.QueryName))]
    [JsonDerivedType(typeof(CurrencyCriteria1Choice.NewCriteria),nameof(CurrencyCriteria1Choice.NewCriteria))]
    [IsoId("_705FRaMgEeCJ6YNENx4h-w_-1353697614")]
    [DisplayName("Currency Criteria 1 Choice")]
    public abstract partial record CurrencyCriteria1Choice_
    {
    }
}
