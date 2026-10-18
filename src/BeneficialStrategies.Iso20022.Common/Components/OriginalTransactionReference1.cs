// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference1"/>
[IsoId("_Ps9tRdp-Ed-ak6NoX_4Aeg_-1680728348")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference1
{
    /// <inheritdoc cref="IOriginalTransactionReference1.InterbankSettlementAmount"/>
    [IsoId("_Ps9tRtp-Ed-ak6NoX_4Aeg_-1680728151")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public CurrencyAndAmount? InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.Amount"/>
    [IsoId("_Ps9tR9p-Ed-ak6NoX_4Aeg_-2039915896")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType2Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.InterbankSettlementDate"/>
    [IsoId("_Ps9tSNp-Ed-ak6NoX_4Aeg_-1680727891")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.RequestedExecutionDate"/>
    [IsoId("_PtG3MNp-Ed-ak6NoX_4Aeg_-1873268396")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.RequestedCollectionDate"/>
    [IsoId("_PtG3Mdp-Ed-ak6NoX_4Aeg_-1944377993")]
    [DisplayName("Requested Collection Date")]
    [IsoXmlTag("ReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedCollectionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.CreditorSchemeIdentification"/>
    [IsoId("_PtG3Mtp-Ed-ak6NoX_4Aeg_1486296831")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification8? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.SettlementInformation"/>
    [IsoId("_PtG3M9p-Ed-ak6NoX_4Aeg_1495406470")]
    [DisplayName("Settlement Information")]
    [IsoXmlTag("SttlmInf")]
    public SettlementInformation3? SettlementInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.PaymentTypeInformation"/>
    [IsoId("_PtG3NNp-Ed-ak6NoX_4Aeg_2108028643")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation6? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.PaymentMethod"/>
    [IsoId("_PtG3Ndp-Ed-ak6NoX_4Aeg_-1378135971")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.MandateRelatedInformation"/>
    [IsoId("_PtG3Ntp-Ed-ak6NoX_4Aeg_1486296659")]
    [DisplayName("Mandate Related Information")]
    [IsoXmlTag("MndtRltdInf")]
    public MandateRelatedInformation1? MandateRelatedInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.RemittanceInformation"/>
    [IsoId("_PtG3N9p-Ed-ak6NoX_4Aeg_-1680726804")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation1? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.UltimateDebtor"/>
    [IsoId("_PtG3ONp-Ed-ak6NoX_4Aeg_-1679804817")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification8? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.Debtor"/>
    [IsoId("_PtG3Odp-Ed-ak6NoX_4Aeg_-1679804877")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification8? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.DebtorAccount"/>
    [IsoId("_PtQoMNp-Ed-ak6NoX_4Aeg_-1680725952")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount7? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.DebtorAgent"/>
    [IsoId("_PtQoMdp-Ed-ak6NoX_4Aeg_-1679805885")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.DebtorAgentAccount"/>
    [IsoId("_PtQoMtp-Ed-ak6NoX_4Aeg_-1680727314")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount7? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.CreditorAgent"/>
    [IsoId("_PtQoM9p-Ed-ak6NoX_4Aeg_-1679805825")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.CreditorAgentAccount"/>
    [IsoId("_PtQoNNp-Ed-ak6NoX_4Aeg_-1680727356")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.Creditor"/>
    [IsoId("_PtQoNdp-Ed-ak6NoX_4Aeg_-1679805238")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification8? Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.CreditorAccount"/>
    [IsoId("_PtQoNtp-Ed-ak6NoX_4Aeg_-1680726864")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount7? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference1.UltimateCreditor"/>
    [IsoId("_PtQoN9p-Ed-ak6NoX_4Aeg_-1679805298")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification8? UltimateCreditor { get; init; }
}
