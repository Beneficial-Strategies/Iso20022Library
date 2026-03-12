// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the margin requirements for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(MarginRequirement1Choice.MarginRequirement))]
    [KnownType(typeof(MarginRequirement1Choice.SegregatedIndependentAmountRequirement))]
    [JsonDerivedType(typeof(MarginRequirement1Choice.MarginRequirement),nameof(MarginRequirement1Choice.MarginRequirement))]
    [JsonDerivedType(typeof(MarginRequirement1Choice.SegregatedIndependentAmountRequirement),nameof(MarginRequirement1Choice.SegregatedIndependentAmountRequirement))]
    [IsoId("_QmevONp-Ed-ak6NoX_4Aeg_-593475226")]
    [DisplayName("Margin Requirement 1 Choice")]
    public abstract partial record MarginRequirement1Choice_
    {
    }
}
