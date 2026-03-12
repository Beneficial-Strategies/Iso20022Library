// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the identification of the MarginCallRequest message, the MarginCallResponse message, the CollateralProposal message, the CollateralProposalResponse message, the CollateralSubstitutionRequest message or the MarginCallDisputeNotification message.
    /// </summary>
    [KnownType(typeof(Reference1Choice.MarginCallRequestIdentification))]
    [KnownType(typeof(Reference1Choice.MarginCallResponseIdentification))]
    [KnownType(typeof(Reference1Choice.CollateralProposalIdentification))]
    [KnownType(typeof(Reference1Choice.CollateralProposalResponseIdentification))]
    [KnownType(typeof(Reference1Choice.DisputeNotificationIdentification))]
    [KnownType(typeof(Reference1Choice.CollateralSubstitutionRequestIdentification))]
    [JsonDerivedType(typeof(Reference1Choice.MarginCallRequestIdentification),nameof(Reference1Choice.MarginCallRequestIdentification))]
    [JsonDerivedType(typeof(Reference1Choice.MarginCallResponseIdentification),nameof(Reference1Choice.MarginCallResponseIdentification))]
    [JsonDerivedType(typeof(Reference1Choice.CollateralProposalIdentification),nameof(Reference1Choice.CollateralProposalIdentification))]
    [JsonDerivedType(typeof(Reference1Choice.CollateralProposalResponseIdentification),nameof(Reference1Choice.CollateralProposalResponseIdentification))]
    [JsonDerivedType(typeof(Reference1Choice.DisputeNotificationIdentification),nameof(Reference1Choice.DisputeNotificationIdentification))]
    [JsonDerivedType(typeof(Reference1Choice.CollateralSubstitutionRequestIdentification),nameof(Reference1Choice.CollateralSubstitutionRequestIdentification))]
    [IsoId("_QmxqItp-Ed-ak6NoX_4Aeg_261203016")]
    [DisplayName("Reference 1 Choice")]
    public abstract partial record Reference1Choice_
    {
    }
}
