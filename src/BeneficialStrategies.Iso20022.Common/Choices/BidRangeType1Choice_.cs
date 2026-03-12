// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Bid range type as a choice of a defined coded value or a proprietary value. 
    /// </summary>
    [KnownType(typeof(BidRangeType1Choice.Code))]
    [KnownType(typeof(BidRangeType1Choice.Proprietary))]
    [JsonDerivedType(typeof(BidRangeType1Choice.Code),nameof(BidRangeType1Choice.Code))]
    [JsonDerivedType(typeof(BidRangeType1Choice.Proprietary),nameof(BidRangeType1Choice.Proprietary))]
    [IsoId("_TIIuYO3NEeqc-LCjwLsUVg")]
    [DisplayName("Bid Range Type 1 Choice")]
    public abstract partial record BidRangeType1Choice_
    {
    }
}
