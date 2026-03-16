// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details about the agreed amount for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(AgreedAmount1Choice.AgreedAmountDetails))]
    [KnownType(typeof(AgreedAmount1Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(
        typeof(AgreedAmount1Choice.AgreedAmountDetails),
        nameof(AgreedAmount1Choice.AgreedAmountDetails)
    )]
    [JsonDerivedType(
        typeof(AgreedAmount1Choice.SegregatedIndependentAmount),
        nameof(AgreedAmount1Choice.SegregatedIndependentAmount)
    )]
    [IsoId("_Qm7bJdp-Ed-ak6NoX_4Aeg_926398968")]
    [DisplayName("Agreed Amount 1 Choice")]
    public abstract record AgreedAmount1Choice_ { }
}
