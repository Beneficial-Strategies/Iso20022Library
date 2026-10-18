// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference35"/>
[IsoId("_a0FXYdcZEeqRFcf2R4bPBw")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference35
{
    /// <inheritdoc cref="IOriginalTransactionReference35.InterbankSettlementAmount"/>
    [IsoId("_a1eegdcZEeqRFcf2R4bPBw")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.Amount"/>
    [IsoId("_a1eeg9cZEeqRFcf2R4bPBw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.InterbankSettlementDate"/>
    [IsoId("_a1eehdcZEeqRFcf2R4bPBw")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.RequestedCollectionDate"/>
    [IsoId("_a1eeh9cZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.RequestedExecutionDate"/>
    [IsoId("_a1eeidcZEeqRFcf2R4bPBw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.CreditorSchemeIdentification"/>
    [IsoId("_a1eei9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.SettlementInformation"/>
    [IsoId("_a1eejdcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction11? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.PaymentTypeInformation"/>
    [IsoId("_a1eej9cZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.PaymentMethod"/>
    [IsoId("_a1eekdcZEeqRFcf2R4bPBw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.MandateRelatedInformation"/>
    [IsoId("_a1eek9cZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedData2Choice_? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.RemittanceInformation"/>
    [IsoId("_a1fFkdcZEeqRFcf2R4bPBw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation21? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.UltimateDebtor"/>
    [IsoId("_a1fFk9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public Party40Choice_? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.Debtor"/>
    [IsoId("_a1fFldcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public Party40Choice_? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.DebtorAccount"/>
    [IsoId("_a1fFl9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.DebtorAgent"/>
    [IsoId("_a1fFmdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.DebtorAgentAccount"/>
    [IsoId("_a1fFm9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.CreditorAgent"/>
    [IsoId("_a1fFndcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.CreditorAgentAccount"/>
    [IsoId("_a1fFn9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount40? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.Creditor"/>
    [IsoId("_a1fFodcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public Party40Choice_? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.CreditorAccount"/>
    [IsoId("_a1fFo9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.UltimateCreditor"/>
    [IsoId("_a1fFpdcZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public Party40Choice_? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference35.Purpose"/>
    [IsoId("_a1fFp9cZEeqRFcf2R4bPBw")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }
}
