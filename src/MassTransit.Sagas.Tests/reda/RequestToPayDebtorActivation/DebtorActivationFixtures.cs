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
    public static IRTPPartyIdentification2 AParty(string name) => IsoDataFactory.Make<IRTPPartyIdentification2>(b => b
        .Set(x => x.Name).To(name));

    public static IRequestToPayDebtorActivationRequestV02 ARequest(string messageId) =>
        IsoDataFactory.Make<IRequestToPayDebtorActivationRequestV02>(b => b
            .Set(x => x.Header).To(IsoDataFactory.Make<IActivationHeader3>(b2 => b2
                .Set(x2 => x2.CreationDateTime).To(DateTime.UtcNow)
                .Set(x2 => x2.InitiatingParty).To(AParty("Debtor RTP Service Provider"))
                .Set(x2 => x2.MessageIdentification).To(messageId)))
            .Set(x => x.ElectronicInvoiceData).To(IsoDataFactory.Make<IElectronicInvoice1>(b2 => b2
                .Set(x2 => x2.PresentmentType).To(PresentmentType1Code.Full)))
            .Set(x => x.DebtorActivation).To([
                IsoDataFactory.Make<IDebtorActivation5>(b2 => b2
                    .Set(x2 => x2.Debtor).To(AParty("Jane Debtor"))
                    .Set(x2 => x2.Creditor).To(AParty("Acme Payee Ltd"))
                    .Set(x2 => x2.DebtorSolutionProvider).To(AParty("Debtor Solution Provider"))),
            ]));

    public static IRequestToPayDebtorActivationStatusReportV02 AStatusReport(
        string messageId,
        string originalMessageId,
        ServiceRequestStatus1Code status
    ) =>
        IsoDataFactory.Make<IRequestToPayDebtorActivationStatusReportV02>(b => b
            .Set(x => x.Header).To(IsoDataFactory.Make<IActivationHeader3>(b2 => b2
                .Set(x2 => x2.CreationDateTime).To(DateTime.UtcNow)
                .Set(x2 => x2.InitiatingParty).To(AParty("Creditor RTP Service Provider"))
                .Set(x2 => x2.MessageIdentification).To(messageId)))
            .Set(x => x.OriginalActivationAndStatus).To([
                IsoDataFactory.Make<IActivationStatus3>(b2 => b2
                    .Set(x2 => x2.Status).To(IsoDataFactory.Make<ServiceStatus1Choice.ICode>(b3 => b3
                        .Set(x3 => x3.Value).To(status)))
                    .Set(x2 => x2.OriginalBusinessInstruction).To(IsoDataFactory.Make<IOriginalBusinessInstruction1>(b3 => b3
                        .Set(x3 => x3.MessageIdentification).To(originalMessageId)))),
            ]));

    /// <summary>
    /// References the original activation via <c>OriginalBusinessInstruction</c> only (an empty
    /// <c>OrganisationIdentification40</c> for <c>OriginalActivation</c> — no LEI/AnyBIC/Other —
    /// deliberately, so tests exercising the message-id correlation path aren't accidentally
    /// passing via the party-identity fallback instead). Mirrors <c>CreditorEnrolmentFixtures.AAmendment</c>.
    /// </summary>
    public static IRequestToPayDebtorActivationAmendmentRequestV02 AAmendment(
        string messageId,
        string originalRequestMessageId
    ) =>
        IsoDataFactory.Make<IRequestToPayDebtorActivationAmendmentRequestV02>(b => b
            .Set(x => x.Header).To(IsoDataFactory.Make<IActivationHeader3>(b2 => b2
                .Set(x2 => x2.CreationDateTime).To(DateTime.UtcNow)
                .Set(x2 => x2.InitiatingParty).To(AParty("Debtor RTP Service Provider"))
                .Set(x2 => x2.MessageIdentification).To(messageId)))
            .Set(x => x.AmendmentData).To([
                IsoDataFactory.Make<IDebtorActivationAmendment5>(b2 => b2
                    .Set(x2 => x2.Amendment).To(IsoDataFactory.Make<IDebtorActivationAmendment6>())
                    .Set(x2 => x2.OriginalActivation).To(IsoDataFactory.Make<OriginalActivation3Choice.IOriginalDebtorIdentification>(b3 => b3
                        .Set(x3 => x3.Value).To(IsoDataFactory.Make<Party53Choice.IOrganisationIdentification>(b4 => b4
                            .Set(x4 => x4.Value).To(IsoDataFactory.Make<IOrganisationIdentification40>())))))
                    .Set(x2 => x2.OriginalBusinessInstruction).To(IsoDataFactory.Make<IOriginalBusinessInstruction1>(b3 => b3
                        .Set(x3 => x3.MessageIdentification).To(originalRequestMessageId)))),
            ]));
}
