// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of the message to be cancelled.
    /// </summary>
    [KnownType(typeof(Reference3Choice.ClientCollateralInstructionIdentification))]
    [KnownType(typeof(Reference3Choice.ClientCollateralTransactionIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralProposalIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralProposalResponseIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralSubstitutionConfirmationIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralSubstitutionRequestIdentification))]
    [KnownType(typeof(Reference3Choice.CollateralSubstitutionResponseIdentification))]
    [KnownType(typeof(Reference3Choice.CommonTransactionIdentification))]
    [KnownType(typeof(Reference3Choice.DisputeNotificationIdentification))]
    [KnownType(typeof(Reference3Choice.InterestPaymentRequestIdentification))]
    [KnownType(typeof(Reference3Choice.InterestPaymentResponseIdentification))]
    [KnownType(typeof(Reference3Choice.InterestPaymentStatementIdentification))]
    [KnownType(typeof(Reference3Choice.MarginCallRequestIdentification))]
    [KnownType(typeof(Reference3Choice.MarginCallResponseIdentification))]
    [KnownType(typeof(Reference3Choice.TripartyAgentServiceProviderCollateralInstructionIdentification))]
    [KnownType(typeof(Reference3Choice.TripartyAgentServiceProviderCollateralTransactionIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.ClientCollateralInstructionIdentification),nameof(Reference3Choice.ClientCollateralInstructionIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.ClientCollateralTransactionIdentification),nameof(Reference3Choice.ClientCollateralTransactionIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.CollateralProposalIdentification),nameof(Reference3Choice.CollateralProposalIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.CollateralProposalResponseIdentification),nameof(Reference3Choice.CollateralProposalResponseIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.CollateralSubstitutionConfirmationIdentification),nameof(Reference3Choice.CollateralSubstitutionConfirmationIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.CollateralSubstitutionRequestIdentification),nameof(Reference3Choice.CollateralSubstitutionRequestIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.CollateralSubstitutionResponseIdentification),nameof(Reference3Choice.CollateralSubstitutionResponseIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.CommonTransactionIdentification),nameof(Reference3Choice.CommonTransactionIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.DisputeNotificationIdentification),nameof(Reference3Choice.DisputeNotificationIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.InterestPaymentRequestIdentification),nameof(Reference3Choice.InterestPaymentRequestIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.InterestPaymentResponseIdentification),nameof(Reference3Choice.InterestPaymentResponseIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.InterestPaymentStatementIdentification),nameof(Reference3Choice.InterestPaymentStatementIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.MarginCallRequestIdentification),nameof(Reference3Choice.MarginCallRequestIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.MarginCallResponseIdentification),nameof(Reference3Choice.MarginCallResponseIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.TripartyAgentServiceProviderCollateralInstructionIdentification),nameof(Reference3Choice.TripartyAgentServiceProviderCollateralInstructionIdentification))]
    [JsonDerivedType(typeof(Reference3Choice.TripartyAgentServiceProviderCollateralTransactionIdentification),nameof(Reference3Choice.TripartyAgentServiceProviderCollateralTransactionIdentification))]
    [IsoId("_d0qV3ALyEeutW5-TpeYJhA")]
    [DisplayName("Reference 3 Choice")]
    public abstract partial record Reference3Choice_
    {
    }
}
