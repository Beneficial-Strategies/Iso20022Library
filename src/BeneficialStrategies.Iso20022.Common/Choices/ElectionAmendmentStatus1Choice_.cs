// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the different statuses of an election amendment request.
    /// </summary>
    [KnownType(typeof(ElectionAmendmentStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(ElectionAmendmentStatus1Choice.RejectedStatus))]
    [JsonDerivedType(typeof(ElectionAmendmentStatus1Choice.ProcessedStatus),nameof(ElectionAmendmentStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(ElectionAmendmentStatus1Choice.RejectedStatus),nameof(ElectionAmendmentStatus1Choice.RejectedStatus))]
    [IsoId("_RiiHxdp-Ed-ak6NoX_4Aeg_1987378998")]
    [DisplayName("Election Amendment Status 1 Choice")]
    public abstract partial record ElectionAmendmentStatus1Choice_
    {
    }
}
