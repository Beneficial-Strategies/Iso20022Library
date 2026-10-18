// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference24"/>
[IsoId("_Tpe00WXlEeap-P22vGV91g")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference24
{
    /// <inheritdoc cref="IOriginalTransactionReference24.InterbankSettlementAmount"/>
    [IsoId("_T0i1IWXlEeap-P22vGV91g")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.Amount"/>
    [IsoId("_T0i1I2XlEeap-P22vGV91g")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.InterbankSettlementDate"/>
    [IsoId("_T0i1JWXlEeap-P22vGV91g")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.RequestedCollectionDate"/>
    [IsoId("_T0i1J2XlEeap-P22vGV91g")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.RequestedExecutionDate"/>
    [IsoId("_T0i1KWXlEeap-P22vGV91g")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTimeChoice_? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.CreditorSchemeIdentification"/>
    [IsoId("_T0i1K2XlEeap-P22vGV91g")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.SettlementInformation"/>
    [IsoId("_T0i1LWXlEeap-P22vGV91g")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInstruction4? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.PaymentTypeInformation"/>
    [IsoId("_T0i1L2XlEeap-P22vGV91g")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation25? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.PaymentMethod"/>
    [IsoId("_T0i1MWXlEeap-P22vGV91g")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.MandateRelatedInformation"/>
    [IsoId("_T0i1M2XlEeap-P22vGV91g")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation11? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.RemittanceInformation"/>
    [IsoId("_T0i1NWXlEeap-P22vGV91g")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation11? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.UltimateDebtor"/>
    [IsoId("_T0i1N2XlEeap-P22vGV91g")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.Debtor"/>
    [IsoId("_T0i1OWXlEeap-P22vGV91g")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.DebtorAccount"/>
    [IsoId("_T0i1O2XlEeap-P22vGV91g")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.DebtorAgent"/>
    [IsoId("_T0i1PWXlEeap-P22vGV91g")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.DebtorAgentAccount"/>
    [IsoId("_T0i1P2XlEeap-P22vGV91g")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount24? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.CreditorAgent"/>
    [IsoId("_T0i1QWXlEeap-P22vGV91g")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.CreditorAgentAccount"/>
    [IsoId("_T0i1Q2XlEeap-P22vGV91g")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.Creditor"/>
    [IsoId("_T0i1RWXlEeap-P22vGV91g")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.CreditorAccount"/>
    [IsoId("_T0i1R2XlEeap-P22vGV91g")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference24.UltimateCreditor"/>
    [IsoId("_T0i1SWXlEeap-P22vGV91g")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
