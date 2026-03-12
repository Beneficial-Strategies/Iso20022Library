// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the different statuses of a movement.
    /// </summary>
    [KnownType(typeof(CorporateActionMovementStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(CorporateActionMovementStatus1Choice.FailedStatus))]
    [KnownType(typeof(CorporateActionMovementStatus1Choice.RejectedStatus))]
    [JsonDerivedType(typeof(CorporateActionMovementStatus1Choice.ProcessedStatus),nameof(CorporateActionMovementStatus1Choice.ProcessedStatus))]
    [JsonDerivedType(typeof(CorporateActionMovementStatus1Choice.FailedStatus),nameof(CorporateActionMovementStatus1Choice.FailedStatus))]
    [JsonDerivedType(typeof(CorporateActionMovementStatus1Choice.RejectedStatus),nameof(CorporateActionMovementStatus1Choice.RejectedStatus))]
    [IsoId("_RiPM1dp-Ed-ak6NoX_4Aeg_-2034263409")]
    [DisplayName("Corporate Action Movement Status 1 Choice")]
    public abstract partial record CorporateActionMovementStatus1Choice_
    {
    }
}
