// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDirectDebitTransactionInformation25"/>
[IsoId("_4ZCaVXL-EeidQ_AAdEzxQA")]
[DisplayName("Direct Debit Transaction Information")]
public partial record DirectDebitTransactionInformation25
{
    /// <inheritdoc cref="IDirectDebitTransactionInformation25.PaymentIdentification"/>
    [IsoId("_4jnSZXL-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification7 PaymentIdentification { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.PaymentTypeInformation"/>
    [IsoId("_4jnSZ3L-EeidQ_AAdEzxQA")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.InterbankSettlementAmount"/>
    [IsoId("_4jnSaXL-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required ActiveCurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.InterbankSettlementDate"/>
    [IsoId("_4jnSa3L-EeidQ_AAdEzxQA")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.SettlementPriority"/>
    [IsoId("_4jnSbXL-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.SettlementTimeIndication"/>
    [IsoId("_f2eo8XRsEeiH1ZOt2UD8vQ")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.SettlementTimeRequest"/>
    [IsoId("_4jnSb3L-EeidQ_AAdEzxQA")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.UltimateDebtor"/>
    [IsoId("_4jnScXL-EeidQ_AAdEzxQA")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification6? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.Debtor"/>
    [IsoId("_4jnSc3L-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification6 Debtor { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.DebtorAccount"/>
    [IsoId("_4jnSdXL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.DebtorAgent"/>
    [IsoId("_4jnSd3L-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.DebtorAgentAccount"/>
    [IsoId("_4jnSeXL-EeidQ_AAdEzxQA")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount38? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.InstructionForDebtorAgent"/>
    [IsoId("_4jnSe3L-EeidQ_AAdEzxQA")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.Purpose"/>
    [IsoId("_pn02EIjXEei-69PNFxn_Ew")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="IDirectDebitTransactionInformation25.RemittanceInformation"/>
    [IsoId("_4jnSfXL-EeidQ_AAdEzxQA")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }
}
