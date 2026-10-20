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
    public static IRTPPartyIdentification2 ACreditor() => IsoDataFactory.Make<IRTPPartyIdentification2>(b => b
        .Set(x => x.Name).To("Acme Payee Ltd"));

    public static IRequestToPayCreditorEnrolmentRequestV02 ARequest(string messageId, int lineItems = 1) =>
        IsoDataFactory.Make<IRequestToPayCreditorEnrolmentRequestV02>(b => b
            .Set(x => x.Header).To(IsoDataFactory.Make<IEnrolmentHeader3>(b2 => b2
                .Set(x2 => x2.CreationDateTime).To(DateTime.UtcNow)
                .Set(x2 => x2.InitiatingParty).To(ACreditor())
                .Set(x2 => x2.MessageIdentification).To(messageId)))
            .Set(x => x.ActivationData).To(IsoDataFactory.Make<ICreditorInvoice6>(b2 => b2
                .Set(x2 => x2.ActivationRequestDeliveryParty).To(ACreditor())
                .Set(x2 => x2.LimitedPresentmentIndicator).To(false)))
            .Set(x => x.CreditorEnrolment).To([
                .. Enumerable
                    .Range(0, lineItems)
                    .Select(_ => IsoDataFactory.Make<ICreditorEnrolment5>(b2 => b2
                        .Set(x2 => x2.Creditor).To(ACreditor())
                        .Set(x2 => x2.MerchantCategoryCode).To("5411")
                        .Set(x2 => x2.Enrolment).To(IsoDataFactory.Make<ICreditorServiceEnrolment1>(b3 => b3
                            .Set(x3 => x3.ServiceActivationAllowed).To(true))))),
            ]));

    public static IRequestToPayCreditorEnrolmentStatusReportV02 AStatusReport(
        string messageId,
        string originalMessageId,
        ServiceRequestStatus1Code status
    ) =>
        IsoDataFactory.Make<IRequestToPayCreditorEnrolmentStatusReportV02>(b => b
            .Set(x => x.Header).To(IsoDataFactory.Make<IEnrolmentHeader3>(b2 => b2
                .Set(x2 => x2.CreationDateTime).To(DateTime.UtcNow)
                .Set(x2 => x2.InitiatingParty).To(ACreditor())
                .Set(x2 => x2.MessageIdentification).To(messageId)))
            .Set(x => x.OriginalEnrolmentAndStatus).To([
                IsoDataFactory.Make<IEnrolmentStatus3>(b2 => b2
                    .Set(x2 => x2.Status).To(IsoDataFactory.Make<ServiceStatus1Choice.ICode>(b3 => b3
                        .Set(x3 => x3.Value).To(status)))
                    .Set(x2 => x2.OriginalBusinessInstruction).To(IsoDataFactory.Make<IOriginalBusinessInstruction1>(b3 => b3
                        .Set(x3 => x3.MessageIdentification).To(originalMessageId)))),
            ]));

    /// <summary>
    /// References the original enrolment via <c>OriginalBusinessInstruction</c> only (an empty
    /// <c>OrganisationIdentification40</c> for <c>OriginalEnrolment</c> — no LEI/AnyBIC/Other —
    /// deliberately, so tests exercising the message-id correlation path aren't accidentally
    /// passing via the party-identity fallback instead).
    /// </summary>
    public static IRequestToPayCreditorEnrolmentAmendmentRequestV02 AAmendment(
        string messageId,
        string originalRequestMessageId
    ) =>
        IsoDataFactory.Make<IRequestToPayCreditorEnrolmentAmendmentRequestV02>(b => b
            .Set(x => x.Header).To(IsoDataFactory.Make<IEnrolmentHeader3>(b2 => b2
                .Set(x2 => x2.CreationDateTime).To(DateTime.UtcNow)
                .Set(x2 => x2.InitiatingParty).To(ACreditor())
                .Set(x2 => x2.MessageIdentification).To(messageId)))
            .Set(x => x.AmendmentData).To([
                IsoDataFactory.Make<ICreditorEnrolmentAmendment5>(b2 => b2
                    .Set(x2 => x2.Amendment).To(IsoDataFactory.Make<ICreditorEnrolmentAmendment6>())
                    .Set(x2 => x2.OriginalEnrolment).To(IsoDataFactory.Make<OriginalEnrolment3Choice.IOriginalCreditorIdentification>(b3 => b3
                        .Set(x3 => x3.Value).To(IsoDataFactory.Make<Party53Choice.IOrganisationIdentification>(b4 => b4
                            .Set(x4 => x4.Value).To(IsoDataFactory.Make<IOrganisationIdentification40>())))))
                    .Set(x2 => x2.OriginalBusinessInstruction).To(IsoDataFactory.Make<IOriginalBusinessInstruction1>(b3 => b3
                        .Set(x3 => x3.MessageIdentification).To(originalRequestMessageId)))),
            ]));
}
