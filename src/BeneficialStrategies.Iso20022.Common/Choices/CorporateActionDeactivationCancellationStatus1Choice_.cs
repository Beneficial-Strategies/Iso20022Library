// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the different statuses of a deactivation cancellation request.
    /// </summary>
    [KnownType(typeof(CorporateActionDeactivationCancellationStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(CorporateActionDeactivationCancellationStatus1Choice.RejectedStatus))]
    [JsonDerivedType(typeof(CorporateActionDeactivationCancellationStatus1Choice.ProcessedStatus),nameof(CorporateActionDeactivationCancellationStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(CorporateActionDeactivationCancellationStatus1Choice.RejectedStatus),nameof(CorporateActionDeactivationCancellationStatus1Choice.RejectedStatus))]
    [IsoId("_RiYWwNp-Ed-ak6NoX_4Aeg_1248187111")]
    [DisplayName("Corporate Action Deactivation Cancellation Status 1 Choice")]
    public abstract partial record CorporateActionDeactivationCancellationStatus1Choice_
    {
    }
}
