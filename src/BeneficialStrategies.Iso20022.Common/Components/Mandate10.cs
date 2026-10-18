// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate10"/>
[IsoId("_dTODi0jwEeaVLL5QKJ4f-A")]
[DisplayName("Mandate")]
public partial record Mandate10
{
    /// <inheritdoc cref="IMandate10.MandateIdentification"/>
    [IsoId("_dceGJ0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public SimpleValueList<IsoMax35Text> MandateIdentification { get; init; } = [];

    /// <inheritdoc cref="IMandate10.MandateRequestIdentification"/>
    [IsoId("_dceGKUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate10.Authentication"/>
    [IsoId("_fE0IMGoGEearR-CA7eRZXQ")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <inheritdoc cref="IMandate10.Type"/>
    [IsoId("_dceGK0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <inheritdoc cref="IMandate10.Occurrences"/>
    [IsoId("_dceGLUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences4? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate10.TrackingIndicator"/>
    [IsoId("_KrblMZdhEea1K6JAcAwoVg")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <inheritdoc cref="IMandate10.FirstCollectionAmount"/>
    [IsoId("_n9rlUWoREearR-CA7eRZXQ")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate10.CollectionAmount"/>
    [IsoId("_dceGL0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate10.MaximumAmount"/>
    [IsoId("_dceGMUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate10.Adjustment"/>
    [IsoId("_LKg88WoGEearR-CA7eRZXQ")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <inheritdoc cref="IMandate10.Reason"/>
    [IsoId("_dceGM0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate10.CreditorSchemeIdentification"/>
    [IsoId("_dceGNUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate10.Creditor"/>
    [IsoId("_dceGN0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IMandate10.CreditorAccount"/>
    [IsoId("_dceGOUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate10.CreditorAgent"/>
    [IsoId("_dceGO0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate10.UltimateCreditor"/>
    [IsoId("_dceGPUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate10.Debtor"/>
    [IsoId("_dceGP0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IMandate10.DebtorAccount"/>
    [IsoId("_dceGQUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate10.DebtorAgent"/>
    [IsoId("_dceGQ0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate10.UltimateDebtor"/>
    [IsoId("_dceGRUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate10.MandateReference"/>
    [IsoId("_0HLqsZR3EeazAtAtDSg0Nw")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateReference { get; init; }

    /// <inheritdoc cref="IMandate10.ReferredDocument"/>
    [IsoId("_dceGR0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredMandateDocument1> ReferredDocument { get; init; } = [];

    /// <inheritdoc cref="IMandate10.SupplementaryData"/>
    [IsoId("_dceGSUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
