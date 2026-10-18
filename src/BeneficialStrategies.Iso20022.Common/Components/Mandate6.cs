// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate6"/>
[IsoId("_Y12XRx77EeSxevWRRWxNAg")]
[DisplayName("Mandate")]
public partial record Mandate6
{
    /// <inheritdoc cref="IMandate6.MandateIdentification"/>
    [IsoId("_ZG1Zdx77EeSxevWRRWxNAg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandate6.MandateRequestIdentification"/>
    [IsoId("_ZG1ZeR77EeSxevWRRWxNAg")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate6.Type"/>
    [IsoId("_ZG1Zex77EeSxevWRRWxNAg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <inheritdoc cref="IMandate6.Occurrences"/>
    [IsoId("_ZG1ZfR77EeSxevWRRWxNAg")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences3? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate6.CollectionAmount"/>
    [IsoId("_ZG1Zfx77EeSxevWRRWxNAg")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate6.MaximumAmount"/>
    [IsoId("_ZG1ZgR77EeSxevWRRWxNAg")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate6.Reason"/>
    [IsoId("_i98BUSL0EeSizvrwx7oJNQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate6.CreditorSchemeIdentification"/>
    [IsoId("_ZG1Zgx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate6.Creditor"/>
    [IsoId("_ZG1ZhR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="IMandate6.CreditorAccount"/>
    [IsoId("_ZG1Zhx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate6.CreditorAgent"/>
    [IsoId("_ZG1ZiR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate6.UltimateCreditor"/>
    [IsoId("_ZG1Zix77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate6.Debtor"/>
    [IsoId("_ZG1ZjR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IMandate6.DebtorAccount"/>
    [IsoId("_ZG1Zjx77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate6.DebtorAgent"/>
    [IsoId("_ZG1ZkR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate6.UltimateDebtor"/>
    [IsoId("_ZG1Zkx77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate6.ReferredDocument"/>
    [IsoId("_ZG1ZlR77EeSxevWRRWxNAg")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredDocumentInformation6> ReferredDocument { get; init; } = [];
}
