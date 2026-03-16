// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Instruction45.
/// </summary>
[IsoId("_88T_QTEsEe6GxLzpkVnWYg")]
[DisplayName("Payment Instruction45")]
public record PaymentInstruction45
{
    /// <summary>
    /// Batch Booking.
    /// </summary>
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <summary>
    /// Charge Bearer.
    /// </summary>
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Charges Account.
    /// </summary>
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount40? ChargesAccount { get; init; }

    /// <summary>
    /// Charges Account Agent.
    /// </summary>
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification8? ChargesAccountAgent { get; init; }

    /// <summary>
    /// Control Sum.
    /// </summary>
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public required CashAccount40 CreditorAccount { get; init; }

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <summary>
    /// Creditor Agent Account.
    /// </summary>
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Creditor Scheme Identification.
    /// </summary>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Direct Debit Transaction Information.
    /// </summary>
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    public ValueList<DirectDebitTransactionInformation32> DirectDebitTransactionInformation { get; init; } =
        [];

    /// <summary>
    /// Number Of Transactions.
    /// </summary>
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <summary>
    /// Payment Information Identification.
    /// </summary>
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Payment Method.
    /// </summary>
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod2Code PaymentMethod { get; init; }

    /// <summary>
    /// Payment Type Information.
    /// </summary>
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Requested Advice Type.
    /// </summary>
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <summary>
    /// Requested Collection Date.
    /// </summary>
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    public required IsoISODate RequestedCollectionDate { get; init; }

    /// <summary>
    /// Ultimate Creditor.
    /// </summary>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }
}
