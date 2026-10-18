// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IOriginalTransactionReference21"/>
[IsoId("_AYcLaVkKEeSeLKjZh_lWZw")]
[DisplayName("Original Transaction Reference")]
public partial record OriginalTransactionReference21
{
    /// <inheritdoc cref="IOriginalTransactionReference21.Amount"/>
    [IsoId("_Ayeb81kKEeSeLKjZh_lWZw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public AmountType4Choice_? Amount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.RequestedExecutionDate"/>
    [IsoId("_Ayeb9VkKEeSeLKjZh_lWZw")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.PaymentTypeInformation"/>
    [IsoId("_Ayeb91kKEeSeLKjZh_lWZw")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.PaymentMethod"/>
    [IsoId("_Ayeb-VkKEeSeLKjZh_lWZw")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public PaymentMethod4Code? PaymentMethod { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.RemittanceInformation"/>
    [IsoId("_Ayeb-1kKEeSeLKjZh_lWZw")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation6? RemittanceInformation { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.UltimateDebtor"/>
    [IsoId("_Ayeb_VkKEeSeLKjZh_lWZw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.Debtor"/>
    [IsoId("_Ayeb_1kKEeSeLKjZh_lWZw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.DebtorAccount"/>
    [IsoId("_AyecAVkKEeSeLKjZh_lWZw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.DebtorAgent"/>
    [IsoId("_AyecA1kKEeSeLKjZh_lWZw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.CreditorAgent"/>
    [IsoId("_AyecBVkKEeSeLKjZh_lWZw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.Creditor"/>
    [IsoId("_AyecB1kKEeSeLKjZh_lWZw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.CreditorAccount"/>
    [IsoId("_AyecCVkKEeSeLKjZh_lWZw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IOriginalTransactionReference21.UltimateCreditor"/>
    [IsoId("_AyecC1kKEeSeLKjZh_lWZw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }
}
