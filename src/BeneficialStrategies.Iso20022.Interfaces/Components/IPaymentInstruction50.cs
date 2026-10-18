// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics that apply to the credit side of the payment transactions included in the direct debit initiation.
/// </summary>
[IsoId("88833a18-3210-4838-a808-05caac40b3f4")]
public interface IPaymentInstruction50 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    [IsoId("0db8143c-3f35-43d6-8305-b1ce885687e1")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    IsoMax35Text PaymentInformationIdentification { get; }

    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("6cd09cd3-0f8d-418b-9b16-f63d5502291f")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    PaymentMethod2Code PaymentMethod { get; }

    /// <summary>
    /// Type of advice details requested.
    /// </summary>
    [IsoId("f073c776-0f5c-4680-9296-acf3a0594cfd")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    IAdviceType1? RequestedAdviceType { get; }

    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.
    /// </summary>
    [IsoId("78735f7e-f6cb-4385-b0be-2d9724c37c17")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    IsoBatchBookingIndicator? BatchBooking { get; }

    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    [IsoId("e1075d7f-6168-4606-a287-fccef6a4226d")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    IsoMax15NumericText? NumberOfTransactions { get; }

    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    [IsoId("13e9d3b6-e22d-4a4d-b7cc-801a6ef0570f")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    IsoDecimalNumber? ControlSum { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("af8624dd-3c3e-422d-8cba-a792851d20db")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation29? PaymentTypeInformation { get; }

    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("90ab1a25-d3b0-44af-b707-657686a70954")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    IsoISODate RequestedCollectionDate { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("063eb865-20b2-478f-a0ad-ec4c8b6887ba")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IPartyIdentification272 Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("cb1718b4-f65a-4e88-a850-4941bd993c78")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40 CreditorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("7f41e68a-0579-47b8-ad66-6e46769a0eb1")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8 CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("a1855646-878a-4901-abaf-5dd43b0eef1c")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("a22d10f9-e87c-4131-8eab-e4c304b0835a")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IPartyIdentification272? UltimateCreditor { get; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("ecd3af9a-967e-472f-a37c-d5c0263250b5")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    ChargeBearerType1Code? ChargeBearer { get; }

    /// <summary>
    /// Account used to process charges associated with a transaction.
    /// </summary>
    [IsoId("ec4d49dc-021a-46c6-958e-69b155026144")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    ICashAccount40? ChargesAccount { get; }

    /// <summary>
    /// Agent that services a charges account.
    /// </summary>
    [IsoId("eb8cb8f0-2de8-438a-a32d-cf706caf5ee2")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    IBranchAndFinancialInstitutionIdentification8? ChargesAccountAgent { get; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("fb17a2ee-e600-4efb-9a91-b3d578848aaa")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification272? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    [IsoId("9f25952d-4690-49c3-a875-7cbd76a528c7")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    IEnumerable<IDirectDebitTransactionInformation34> DirectDebitTransactionInformation { get; }
}
