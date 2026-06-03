// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies key elements as defined in the original transaction.
/// </summary>
[IsoId("b6168479-406c-4e82-b807-50ae6886bee6")]
[DisplayName("Original Transaction Reference47")]
public record OriginalTransactionReference47
{
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("d39996df-b0fe-41fd-98cf-1643722d1864")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("734babc0-496a-4d03-af0e-2bc2418b69cb")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice? Amount { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("d4b6afe1-a35e-4d30-a64f-b09610c54da6")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    [IsoId("44d0a66d-cde0-4022-942f-27b686e23e1a")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment.
    /// </summary>
    [IsoId("2a9f041c-2fbd-4d81-8533-0b646ea8d64f")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    [IsoId("6baed1b4-fc6a-4992-9fc8-28232bf9e9f4")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Specifies the details on how the settlement of the original transaction(s) between the instructing agent and the instructed agent was completed.
    /// </summary>
    [IsoId("1be9b19e-277c-43a8-a46e-57b91fa98d5e")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction15? SettlementInformation { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("70277fc6-d3d5-40ac-b0a1-f370e6f97e00")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("1b99f5c8-275a-437f-88a2-ec0882d9db3a")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    [IsoId("fc567b98-d441-4a81-9445-eee18eae29aa")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedData5Choice? MandateRelatedInformation { get; init; }

    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle.
    /// </summary>
    [IsoId("244480b6-1ea0-4f4c-b5da-00e695b6d0ae")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation26? RemittanceInformation { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("18061f66-cc9b-41af-837e-0fd1dd375540")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party50Choice? UltimateDebtor { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("3fb75c3f-ed40-4acc-97d5-9938f1e4fb94")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party50Choice? Debtor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    [IsoId("71ca4a0a-f729-4ccb-a0a0-0d8881a7c0b3")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("a38d1f7a-ffa5-40ae-aae0-b237f3c5f6bd")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("58b9d896-d612-4c5e-b8f2-991c8534811a")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    [IsoId("76bdfef3-85e9-4f46-930c-5f1421e7d0bf")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    [IsoId("0ae0ca04-76d8-48dc-b7e1-8e8d4b61d05f")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    [IsoId("1857a166-8ee0-46a5-82d5-005fb9c13278")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party50Choice? Creditor { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    [IsoId("a75a4d13-f203-4103-a400-23949b61569b")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    [IsoId("a443ab45-284d-440b-8bb0-cdb9032e7390")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party50Choice? UltimateCreditor { get; init; }

    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("ac34c00d-fa60-4268-be4e-84a6abd37f5f")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice? Purpose { get; init; }
}
