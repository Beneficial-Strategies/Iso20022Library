// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using Party53Choice = BeneficialStrategies.Iso20022.Choices.Party53Choice;
using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;
using OriginalEnrolment3Choice = BeneficialStrategies.Iso20022.Choices.OriginalEnrolment3Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment;

/// <summary>
/// Message-building fixtures shared between <see cref="CreditorEnrolmentServiceProviderStateMachineTests"/>
/// (in-memory saga repository) and <see cref="CreditorEnrolmentSqliteCorrelationTests"/> (real
/// relational EF Core saga repository) — one source of truth so the two test classes exercise the
/// exact same message shapes.
/// </summary>
internal static class CreditorEnrolmentFixtures
{
    public static RTPPartyIdentification2 ACreditor() => new() { Name = "Acme Payee Ltd" };

    public static RequestToPayCreditorEnrolmentRequestV02 ARequest(string messageId, int lineItems = 1) =>
        new()
        {
            Header = new EnrolmentHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = ACreditor(),
                MessageIdentification = messageId,
            },
            ActivationData = new CreditorInvoice6
            {
                ActivationRequestDeliveryParty = ACreditor(),
                LimitedPresentmentIndicator = false,
            },
            CreditorEnrolment =
            [
                .. Enumerable
                    .Range(0, lineItems)
                    .Select(_ => new CreditorEnrolment5
                    {
                        Creditor = ACreditor(),
                        MerchantCategoryCode = "5411",
                        Enrolment = new CreditorServiceEnrolment1 { ServiceActivationAllowed = true },
                    }),
            ],
        };

    public static RequestToPayCreditorEnrolmentStatusReportV02 AStatusReport(
        string messageId,
        string originalMessageId,
        ServiceRequestStatus1Code status
    ) =>
        new()
        {
            Header = new EnrolmentHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = ACreditor(),
                MessageIdentification = messageId,
            },
            OriginalEnrolmentAndStatus =
            [
                new EnrolmentStatus3
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
    /// References the original enrolment via <c>OriginalBusinessInstruction</c> only (an empty
    /// <c>OrganisationIdentification40</c> for <c>OriginalEnrolment</c> — no LEI/AnyBIC/Other —
    /// deliberately, so tests exercising the message-id correlation path aren't accidentally
    /// passing via the party-identity fallback instead).
    /// </summary>
    public static RequestToPayCreditorEnrolmentAmendmentRequestV02 AAmendment(
        string messageId,
        string originalRequestMessageId
    ) =>
        new()
        {
            Header = new EnrolmentHeader3
            {
                CreationDateTime = DateTime.UtcNow,
                InitiatingParty = ACreditor(),
                MessageIdentification = messageId,
            },
            AmendmentData =
            [
                new CreditorEnrolmentAmendment5
                {
                    Amendment = new CreditorEnrolmentAmendment6(),
                    OriginalEnrolment = new OriginalEnrolment3Choice.OriginalCreditorIdentification
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
