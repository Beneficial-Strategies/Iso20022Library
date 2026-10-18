// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference28"/>
[IsoId("_AKL0qW49EeiU9cctagi5ow")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference28
{
    /// <inheritdoc cref="IOriginalTransactionReference28.InterbankSettlementAmount"/>
    [IsoId("_ATlBMW49EeiU9cctagi5ow")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.Amount"/>
    [IsoId("_ATlBM249EeiU9cctagi5ow")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.InterbankSettlementDate"/>
    [IsoId("_ATlBNW49EeiU9cctagi5ow")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.RequestedCollectionDate"/>
    [IsoId("_ATlBN249EeiU9cctagi5ow")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.RequestedExecutionDate"/>
    [IsoId("_ATlBOW49EeiU9cctagi5ow")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.CreditorSchemeIdentification"/>
    [IsoId("_ATlBO249EeiU9cctagi5ow")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.SettlementInformation"/>
    [IsoId("_ATlBPW49EeiU9cctagi5ow")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction7? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.PaymentTypeInformation"/>
    [IsoId("_ATlBP249EeiU9cctagi5ow")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.PaymentMethod"/>
    [IsoId("_ATlBQW49EeiU9cctagi5ow")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.MandateRelatedInformation"/>
    [IsoId("_ATlBQ249EeiU9cctagi5ow")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation14? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.RemittanceInformation"/>
    [IsoId("_ATlBRW49EeiU9cctagi5ow")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation16? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.UltimateDebtor"/>
    [IsoId("_ATlBR249EeiU9cctagi5ow")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.Debtor"/>
    [IsoId("_ATlBSW49EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.DebtorAccount"/>
    [IsoId("_ATlBS249EeiU9cctagi5ow")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.DebtorAgent"/>
    [IsoId("_ATlBTW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.DebtorAgentAccount"/>
    [IsoId("_ATlBT249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.CreditorAgent"/>
    [IsoId("_ATlBUW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.CreditorAgentAccount"/>
    [IsoId("_ATlBU249EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount38? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.Creditor"/>
    [IsoId("_ATlBVW49EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party40Choice_? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.CreditorAccount"/>
    [IsoId("_ATlBV249EeiU9cctagi5ow")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.UltimateCreditor"/>
    [IsoId("_ATlBWW49EeiU9cctagi5ow")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference28.Purpose"/>
    [IsoId("_ATlBW249EeiU9cctagi5ow")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }
}
