// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies key elements as defined in the original transaction.
/// </summary>
[IsoId("4e387edc-deca-49ee-beb0-bf53f204c1d5")]
public interface IOriginalTransactionReference45 : IIsoComponent
{
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("180aa013-d8d9-4de3-9b48-3b3042fc72d9")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("c61bad68-a8e8-46ee-a2e7-a05cb8b38152")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    IAmountType4Choice? Amount { get; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("3c32dfc2-c1db-4ec0-a149-726149999f67")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    IsoISODate? InterbankSettlementDate { get; }

    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("8684b503-00cd-4225-985a-ca07b68b1311")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    IsoISODate? RequestedCollectionDate { get; }

    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment.
    /// </summary>
    [IsoId("183f2e61-e0a8-4b6b-89de-855ae079406f")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    IDateAndDateTime2Choice? RequestedExecutionDate { get; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("09ce3cd5-1700-4912-b897-87b5099a485b")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    IPartyIdentification272? CreditorSchemeIdentification { get; }

    /// <summary>
    /// Specifies the details on how the settlement of the original transaction(s) between the instructing agent and the instructed agent was completed.
    /// </summary>
    [IsoId("bbf11029-ae2a-4ae2-b78e-f7db65d860f5")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    ISettlementInstruction15? SettlementInformation { get; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("5cb90945-a9c8-4fff-a094-ba11b4c9e017")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    IPaymentTypeInformation27? PaymentTypeInformation { get; }

    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("9eb832d5-252a-4315-be2b-61bbe7915624")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    PaymentMethod4Code? PaymentMethod { get; }

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("50d95ab1-d9a2-42b8-b399-92425a5b7015")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    IMandateRelatedData5Choice? MandateRelatedInformation { get; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("5ecbd107-b24b-487d-9082-656294bfcf84")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    IRemittanceInformation26? RemittanceInformation { get; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("17e1d439-c212-4078-9f28-fab70791bb0e")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    IParty50Choice? UltimateDebtor { get; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("f9af9f47-598b-4324-a709-a0d1782d925c")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    IParty50Choice? Debtor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("477776ad-5e74-4533-932c-e227ded14e30")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    ICashAccount40? DebtorAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("1bf8c8aa-cd87-4ee3-9506-eeae190f40e5")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    IBranchAndFinancialInstitutionIdentification8? DebtorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("b4d8de67-81d6-4475-87d6-cee09029564e")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    ICashAccount40? DebtorAgentAccount { get; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("c675b361-f684-4356-84a9-cf8d7d4c9358")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    IBranchAndFinancialInstitutionIdentification8? CreditorAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("36b85fdc-aead-4cfe-b8c2-673dbf8da7da")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    ICashAccount40? CreditorAgentAccount { get; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("b4ebd8d1-cbda-4401-948c-21a8ee154811")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    IParty50Choice? Creditor { get; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("6eb41323-0050-4633-9b79-87f0855a1326")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    ICashAccount40? CreditorAccount { get; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("24b5121b-8d87-4adb-a16a-6a40711f2a5f")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    IParty50Choice? UltimateCreditor { get; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("84d66152-1b10-4cc1-812a-8b1ece617c12")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    IPurpose2Choice? Purpose { get; }

    /// <summary>
    /// Provides information on the underlying customer credit transfer for which cover is provided.
    /// </summary>
    [IsoId("1e949bca-f00c-4063-a62b-ce8091e927b0")]
    [DisplayName("Underlying Customer Credit Transfer")]
    [IsoXmlTag("UndrlygCstmrCdtTrf")]
    ICreditTransferTransaction72? UnderlyingCustomerCreditTransfer { get; }

    /// <summary>
    /// Provides information on the underlying financial institution credit transfer for which cover is provided.
    /// </summary>
    [IsoId("e31f4b31-9b17-4150-aed8-6df2c6530cd1")]
    [DisplayName("Underlying Financial Institution Credit Transfer")]
    [IsoXmlTag("UndrlygFICdtTrf")]
    ICreditTransferTransaction82? UnderlyingFinancialInstitutionCreditTransfer { get; }
}
