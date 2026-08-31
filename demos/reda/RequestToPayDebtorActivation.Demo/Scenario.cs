// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace RequestToPayDebtorActivation.Demo;

/// <summary>
/// Builds the raw ISO 20022 messages this demo publishes. Shaped after the same fixtures used in
/// <c>BeneficialStrategies.Iso20022.MassTransit.Sagas.Tests</c> (already proven to drive the saga
/// correctly) — this file exists purely to keep <c>Program.cs</c> readable as a narration, not to
/// introduce any new message-building logic.
/// </summary>
internal static class Scenario
{
    public static RTPPartyIdentification2 Party(string name) => new() { Name = name };

    /// <summary>
    /// SIMULATING: the Debtor's own RTP Service Provider submitting an activation request for one
    /// debtor — e.g. a bank's mobile app backend, after a customer opts in to Request-to-Pay,
    /// calling out to its RTP Service Provider integration layer, which in turn emits this ISO
    /// 20022 message. In a real deployment this message would arrive over whatever transport that
    /// integration layer uses (AS4, HTTPS, a message queue) and get translated into a bus publish
    /// at the edge of the system — this call stands in for that edge.
    /// </summary>
    public static RequestToPayDebtorActivationRequestV02 ActivationRequest(string messageId) =>
        new()
        {
            Header = new ActivationHeader3
            {
                CreationDateTime = System.DateTime.UtcNow,
                InitiatingParty = Party("Contoso Bank — Debtor RTP Service Provider"),
                MessageIdentification = messageId,
            },
            ElectronicInvoiceData = new ElectronicInvoice1 { PresentmentType = PresentmentType1Code.Full },
            DebtorActivation =
            [
                new DebtorActivation5
                {
                    Debtor = Party("Jane Debtor"),
                    Creditor = Party("Acme Utility Co."),
                    DebtorSolutionProvider = Party("Contoso Bank Digital Channels"),
                    UltimateDebtor = Party("Jane Debtor"),
                },
            ],
        };

    /// <summary>
    /// SIMULATING: the counterpart — the Creditor's RTP Service Provider (via the RTP Directory
    /// Provider, per the source MDR's sequence diagrams) — reporting back the outcome of the
    /// activation some time later. In production this arrives asynchronously, potentially minutes
    /// or hours after the original request, from a different organization entirely.
    /// </summary>
    public static RequestToPayDebtorActivationStatusReportV02 StatusReport(
        string messageId,
        string originalMessageId,
        ServiceRequestStatus1Code status,
        System.DateOnly? effectiveDate = null
    ) =>
        new()
        {
            Header = new ActivationHeader3
            {
                CreationDateTime = System.DateTime.UtcNow,
                InitiatingParty = Party("Acme Utility Co. — Creditor RTP Service Provider"),
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
                    EffectiveActivationDate =
                        effectiveDate is { } date ? new DateAndDateTime2Choice.Date { Value = date } : null,
                },
            ],
        };

    /// <summary>
    /// SIMULATING: the Debtor asking their RTP Service Provider to change something about an
    /// already-activated enrolment (e.g. a re-consent after updating banking details) — referencing
    /// the ORIGINAL activation request's message id, which is why the saga tracks
    /// <c>OriginalMessageIdentification</c> separately from <c>LastMessageIdentification</c>
    /// (see <c>DebtorActivationServiceProviderStateMachine.MatchesEpisode</c>).
    /// </summary>
    public static RequestToPayDebtorActivationAmendmentRequestV02 AmendmentRequest(
        string messageId,
        string originalRequestMessageId
    ) =>
        new()
        {
            Header = new ActivationHeader3
            {
                CreationDateTime = System.DateTime.UtcNow,
                InitiatingParty = Party("Contoso Bank — Debtor RTP Service Provider"),
                MessageIdentification = messageId,
            },
            AmendmentData =
            [
                new DebtorActivationAmendment5
                {
                    Amendment = new DebtorActivationAmendment6
                    {
                        ElectronicInvoiceData = new ElectronicInvoice1 { PresentmentType = PresentmentType1Code.Full },
                    },
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
