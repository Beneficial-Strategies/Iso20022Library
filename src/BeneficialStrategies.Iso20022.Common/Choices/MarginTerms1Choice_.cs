// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the margin terms for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(MarginTerms1Choice.MarginDetails))]
    [KnownType(typeof(MarginTerms1Choice.SegregatedIndependentAmountMargin))]
    [JsonDerivedType(typeof(MarginTerms1Choice.MarginDetails),nameof(MarginTerms1Choice.MarginDetails))]
    [JsonDerivedType(typeof(MarginTerms1Choice.SegregatedIndependentAmountMargin),nameof(MarginTerms1Choice.SegregatedIndependentAmountMargin))]
    [IsoId("_QmogMtp-Ed-ak6NoX_4Aeg_86732419")]
    [DisplayName("Margin Terms 1 Choice")]
    public abstract partial record MarginTerms1Choice_
    {
    }
}
