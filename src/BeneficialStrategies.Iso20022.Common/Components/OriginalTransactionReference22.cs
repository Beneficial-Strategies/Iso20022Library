// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference22"/>
[IsoId("_jAQ0Lzq3EeWZFYSPlduMhw")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference22
{
    /// <inheritdoc cref="IOriginalTransactionReference22.InterbankSettlementAmount"/>
    [IsoId("_jJV3YTq3EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.Amount"/>
    [IsoId("_jJV3Yzq3EeWZFYSPlduMhw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.InterbankSettlementDate"/>
    [IsoId("_jJV3ZTq3EeWZFYSPlduMhw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.RequestedCollectionDate"/>
    [IsoId("_jJV3Zzq3EeWZFYSPlduMhw")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.RequestedExecutionDate"/>
    [IsoId("_jJV3aTq3EeWZFYSPlduMhw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.CreditorSchemeIdentification"/>
    [IsoId("_jJV3azq3EeWZFYSPlduMhw")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.SettlementInformation"/>
    [IsoId("_jJV3bTq3EeWZFYSPlduMhw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction4? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.PaymentTypeInformation"/>
    [IsoId("_jJV3bzq3EeWZFYSPlduMhw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.PaymentMethod"/>
    [IsoId("_jJV3cTq3EeWZFYSPlduMhw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.MandateRelatedInformation"/>
    [IsoId("_jJV3czq3EeWZFYSPlduMhw")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation10? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.RemittanceInformation"/>
    [IsoId("_jJV3dTq3EeWZFYSPlduMhw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation11? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.UltimateDebtor"/>
    [IsoId("_jJV3dzq3EeWZFYSPlduMhw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.Debtor"/>
    [IsoId("_jJV3eTq3EeWZFYSPlduMhw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.DebtorAccount"/>
    [IsoId("_jJV3ezq3EeWZFYSPlduMhw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.DebtorAgent"/>
    [IsoId("_jJV3fTq3EeWZFYSPlduMhw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.DebtorAgentAccount"/>
    [IsoId("_jJV3fzq3EeWZFYSPlduMhw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.CreditorAgent"/>
    [IsoId("_jJV3gTq3EeWZFYSPlduMhw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.CreditorAgentAccount"/>
    [IsoId("_jJV3gzq3EeWZFYSPlduMhw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.Creditor"/>
    [IsoId("_jJV3hTq3EeWZFYSPlduMhw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.CreditorAccount"/>
    [IsoId("_jJV3hzq3EeWZFYSPlduMhw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference22.UltimateCreditor"/>
    [IsoId("_jJV3iTq3EeWZFYSPlduMhw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
