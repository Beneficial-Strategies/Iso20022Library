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
[IsoId("_sr23AFkyEeGeoaLUQk__nA_788351870")]
[DisplayName("Payment Instruction")]
public record PaymentInstruction7
{
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [IsoId("_sr23AVkyEeGeoaLUQk__nA_815624050")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("_ssAoAFkyEeGeoaLUQk__nA_1342619993")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    [IsoId("_ssAoAVkyEeGeoaLUQk__nA_-1287227415")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    [IsoId("_ssAoAlkyEeGeoaLUQk__nA_-760231472")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    [IsoId("_ssAoA1kyEeGeoaLUQk__nA_415136542")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("_ssJx8FkyEeGeoaLUQk__nA_-1757126836")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation24? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("_ssJx8VkyEeGeoaLUQk__nA_1451870292")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("_ssJx8lkyEeGeoaLUQk__nA_-2079031306")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("_ssJx81kyEeGeoaLUQk__nA_-2140262317")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount24 CreditorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("_ssJx9FkyEeGeoaLUQk__nA_-1815144810")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("_ssTi8FkyEeGeoaLUQk__nA_-1048515731")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("_ssTi8VkyEeGeoaLUQk__nA_-1059614508")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_ssTi8lkyEeGeoaLUQk__nA_-2030469097")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: Charges account should be used when charges have to be booked to an account different from the account identified in debtor&apos;s account.
    /// </summary>
    [IsoId("_ssTi81kyEeGeoaLUQk__nA_-1091585272")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount24? ChargesAccount { get; init; }

    /// <summary>
    /// Agent that services a charges account.||Usage: Charges account agent should only be used when the charges account agent is different from the creditor agent.
    /// </summary>
    [IsoId("_sscs4FkyEeGeoaLUQk__nA_1193425166")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification5? ChargesAccountAgent { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("_sscs4VkyEeGeoaLUQk__nA_635309386")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    [IsoId("_sscs4lkyEeGeoaLUQk__nA_-647271213")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation11> DirectDebitTransactionInformation { get; init; } =
        [];
    // ID for the above is _sscs4lkyEeGeoaLUQk__nA_-647271213
}
