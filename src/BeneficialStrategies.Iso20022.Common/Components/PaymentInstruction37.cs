// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics that apply to the credit side of the payment transactions included in the direct debit initiation.
/// </summary>
[IsoId("_iRC3UdolEembTrt_WixjyQ")]
[DisplayName("Payment Instruction")]
public record PaymentInstruction37
{
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [IsoId("_ijsGkdolEembTrt_WixjyQ")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("_ijsGk9olEembTrt_WixjyQ")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <summary>
    /// Type of advice details requested.
    /// </summary>
    [IsoId("_s_YpUNolEembTrt_WixjyQ")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_ijsGldolEembTrt_WixjyQ")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    [IsoId("_ijsGl9olEembTrt_WixjyQ")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    [IsoId("_ijsGmdolEembTrt_WixjyQ")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_ijsGm9olEembTrt_WixjyQ")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("_ijsGndolEembTrt_WixjyQ")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_ijuiwdolEembTrt_WixjyQ")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_ijuiw9olEembTrt_WixjyQ")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount38 CreditorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_ijuixdolEembTrt_WixjyQ")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ijuix9olEembTrt_WixjyQ")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_ijuiydolEembTrt_WixjyQ")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_ijuiy9olEembTrt_WixjyQ")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: Charges account should be used when charges have to be booked to an account different from the account identified in debtor&apos;s account.
    /// </summary>
    [IsoId("_ijuizdolEembTrt_WixjyQ")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount38? ChargesAccount { get; init; }

    /// <summary>
    /// Agent that services a charges account.||Usage: Charges account agent should only be used when the charges account agent is different from the creditor agent.
    /// </summary>
    [IsoId("_ijuiz9olEembTrt_WixjyQ")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_ijui0dolEembTrt_WixjyQ")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    [IsoId("_ijui09olEembTrt_WixjyQ")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation23> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _ijui09olEembTrt_WixjyQ
}
