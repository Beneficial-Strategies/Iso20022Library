// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice to provide the summation of the call amounts for the variation margin and the segregated independent amount, or the segregated independent amount only.
    /// </summary>
    [KnownType(typeof(MarginCallResult1Choice.MarginCallResultDetails))]
    [KnownType(typeof(MarginCallResult1Choice.SegregatedIndependentAmount))]
    [JsonDerivedType(typeof(MarginCallResult1Choice.MarginCallResultDetails),nameof(MarginCallResult1Choice.MarginCallResultDetails))]
    [JsonDerivedType(typeof(MarginCallResult1Choice.SegregatedIndependentAmount),nameof(MarginCallResult1Choice.SegregatedIndependentAmount))]
    [IsoId("_QmevNdp-Ed-ak6NoX_4Aeg_98969044")]
    [DisplayName("Margin Call Result 1 Choice")]
    public abstract partial record MarginCallResult1Choice_
    {
    }
}
