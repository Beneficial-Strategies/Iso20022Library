// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using Party53Choice = BeneficialStrategies.Iso20022.Choices.Party53Choice;
using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;
using OriginalActivation3Choice = BeneficialStrategies.Iso20022.Choices.OriginalActivation3Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation;

/// <summary>
/// Message-building fixtures shared between <see cref="DebtorActivationServiceProviderStateMachineTests"/>
/// (in-memory saga repository) and <see cref="DebtorActivationSqliteCorrelationTests"/> (real
/// relational EF Core saga repository) — one source of truth so the two test classes exercise the
/// exact same message shapes. Mirrors <c>CreditorEnrolmentFixtures</c>.
/// </summary>
internal static class DebtorActivationFixtures
{
    public static RTPPartyIdentification2 AParty(string name) => new() { Name = name };

    public static RequestToPayDebtorActivationRequestV02 ARequest(string messageId) =>
        new()
        {
            Header = new ActivationHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = AParty("Debtor RTP Service Provider"),
                MessageIdentification = messageId,
            },
            ElectronicInvoiceData = new ElectronicInvoice1 { PresentmentType = PresentmentType1Code.Full },
            DebtorActivation =
            [
                new DebtorActivation5
                {
                    Debtor = AParty("Jane Debtor"),
                    Creditor = AParty("Acme Payee Ltd"),
                    DebtorSolutionProvider = AParty("Debtor Solution Provider"),
                },
            ],
        };

    public static RequestToPayDebtorActivationStatusReportV02 AStatusReport(
        string messageId,
        string originalMessageId,
        ServiceRequestStatus1Code status
    ) =>
        new()
        {
            Header = new ActivationHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = AParty("Creditor RTP Service Provider"),
                MessageIdentification = messageId,
            },
            OriginalActivationAndStatus =
            [
                new ActivationStatus3
                {
                    Status = new ServiceStatus1Choice.Code { Value = status },
                    OriginalBusinessInstruction = new OriginalBusinessInstruction1
                    {
                        MessageIdentification = originalMessageId,
                    },
                },
            ],
        };

    /// <summary>
    /// References the original activation via <c>OriginalBusinessInstruction</c> only (an empty
    /// <c>OrganisationIdentification40</c> for <c>OriginalActivation</c> — no LEI/AnyBIC/Other —
    /// deliberately, so tests exercising the message-id correlation path aren't accidentally
    /// passing via the party-identity fallback instead). Mirrors <c>CreditorEnrolmentFixtures.AAmendment</c>.
    /// </summary>
    public static RequestToPayDebtorActivationAmendmentRequestV02 AAmendment(
        string messageId,
        string originalRequestMessageId
    ) =>
        new()
        {
            Header = new ActivationHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = AParty("Debtor RTP Service Provider"),
                MessageIdentification = messageId,
            },
            AmendmentData =
            [
                new DebtorActivationAmendment5
                {
                    Amendment = new DebtorActivationAmendment6(),
                    OriginalActivation = new OriginalActivation3Choice.OriginalDebtorIdentification
                    {
                        Value = new Party53Choice.OrganisationIdentification
                        {
                            Value = new OrganisationIdentification40(),
                        },
                    },
                    OriginalBusinessInstruction = new OriginalBusinessInstruction1
                    {
                        MessageIdentification = originalRequestMessageId,
                    },
                },
            ],
        };
}
