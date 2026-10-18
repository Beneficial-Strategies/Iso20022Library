// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate8"/>
[IsoId("_cdy3Y0jwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate")]
public partial record Mandate8
{
    /// <inheritdoc cref="IMandate8.MandateIdentification"/>
    [IsoId("_cmx0R0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandate8.MandateRequestIdentification"/>
    [IsoId("_cmx0SUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate8.Authentication"/>
    [IsoId("_hxnssWoGEearR-CA7eRZXQ")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <inheritdoc cref="IMandate8.Type"/>
    [IsoId("_cmx0S0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <inheritdoc cref="IMandate8.Occurrences"/>
    [IsoId("_cmx0TUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences4? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate8.TrackingIndicator"/>
    [IsoId("_47Jw42oCEearR-CA7eRZXQ")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <inheritdoc cref="IMandate8.FirstCollectionAmount"/>
    [IsoId("_47Jw5GoCEearR-CA7eRZXQ")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate8.CollectionAmount"/>
    [IsoId("_cmx0T0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate8.MaximumAmount"/>
    [IsoId("_cmx0UUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate8.Adjustment"/>
    [IsoId("_GTgxwGoGEearR-CA7eRZXQ")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <inheritdoc cref="IMandate8.Reason"/>
    [IsoId("_cm364EjwEeaVLL5QKJ4f-A")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate8.CreditorSchemeIdentification"/>
    [IsoId("_cm364kjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate8.Creditor"/>
    [IsoId("_cm365EjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="IMandate8.CreditorAccount"/>
    [IsoId("_cm365kjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate8.CreditorAgent"/>
    [IsoId("_cm366EjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate8.UltimateCreditor"/>
    [IsoId("_cm366kjwEeaVLL5QKJ4f-A")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate8.Debtor"/>
    [IsoId("_cm367EjwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification43? Debtor { get; init; }

    /// <inheritdoc cref="IMandate8.DebtorAccount"/>
    [IsoId("_cm367kjwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate8.DebtorAgent"/>
    [IsoId("_cm368EjwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate8.UltimateDebtor"/>
    [IsoId("_cm368kjwEeaVLL5QKJ4f-A")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate8.MandateReference"/>
    [IsoId("_47Jw5WoCEearR-CA7eRZXQ")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateReference { get; init; }

    /// <inheritdoc cref="IMandate8.ReferredDocument"/>
    [IsoId("_cm369EjwEeaVLL5QKJ4f-A")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredMandateDocument1> ReferredDocument { get; init; } = [];
}
