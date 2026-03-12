// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Criteria for the trade venue identification.
    /// </summary>
    [KnownType(typeof(SecuritiesTradeVenueCriteria1Choice.MIC))]
    [KnownType(typeof(SecuritiesTradeVenueCriteria1Choice.AnyMIC))]
    [JsonDerivedType(typeof(SecuritiesTradeVenueCriteria1Choice.MIC),nameof(SecuritiesTradeVenueCriteria1Choice.MIC))]
    [JsonDerivedType(typeof(SecuritiesTradeVenueCriteria1Choice.AnyMIC),nameof(SecuritiesTradeVenueCriteria1Choice.AnyMIC))]
    [IsoId("_a5LOAx3ZEeWNp95x0ENf8w")]
    [DisplayName("Securities Trade Venue Criteria 1 Choice")]
    public abstract partial record SecuritiesTradeVenueCriteria1Choice_
    {
    }
}
