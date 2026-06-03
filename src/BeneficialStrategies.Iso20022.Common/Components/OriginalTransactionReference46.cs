// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key elements used to refer the original transaction.
/// </summary>
[IsoId("2c1c1fe9-2ee1-4fde-9241-77fb34759ccb")]
[DisplayName("Original Transaction Reference46")]
public record OriginalTransactionReference46
{
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("d5b37171-37e6-4bdb-b441-28e29044a902")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice? Amount { get; init; }

    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment.
    /// </summary>
    [IsoId("2da36558-72f6-4554-9958-2d612fc373ce")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Date by which the debtor must have accepted or rejected the request.
    /// </summary>
    [IsoId("01497799-9d9d-44b3-8c74-9c2badb6277c")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice? ExpiryDate { get; init; }

    /// <summary>
    /// Conditions for the execution of the payment.
    /// </summary>
    [IsoId("2ed7aa04-b688-4780-ae8a-dfd3d10ed70c")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition2? PaymentCondition { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("890e7ac4-9a24-4d11-ba8b-e7558a1b3015")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("8e8f48d1-19a6-47a2-bb2a-8e4ec784de22")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("d5f53155-2e24-439b-80c2-0b6c53aaa93e")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public CreditTransferMandateData1? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("148feddc-2fdf-4f51-8715-7367b8f586e6")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation26? RemittanceInformation { get; init; }

    /// <summary>
    /// Document or template enclosed in the notification.
    /// </summary>
    [IsoId("3086d9d7-fe9e-4cb4-a03e-feef3ef793e8")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public ValueList<Document15> EnclosedFile { get; init; } = [];

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("38ce7664-f64e-4401-921e-2550bdc58094")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("8b623067-e89f-441a-9700-b9f56f047395")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification272? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("8fe927fa-f861-4ee5-83c0-809f669fc428")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("2d13cc60-2767-469b-8e2a-2b0d22f05da8")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("478d68e5-ef4b-45bc-b617-ad057d1703c2")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("43cf0591-5557-45c0-9b21-14f17f443886")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("f07baf01-1a47-4a30-b080-d39c0235dfe6")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("d1c1efdc-f6b7-4957-8b65-3b3566bad034")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("71ee4fa1-9cdc-4d7b-babd-c03b07216af2")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("af5294d9-b77b-4c2a-9bcb-6ace7339c221")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }
}
