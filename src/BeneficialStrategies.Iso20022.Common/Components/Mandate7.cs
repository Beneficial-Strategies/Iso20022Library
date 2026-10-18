// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate7"/>
[IsoId("_aLTuRx77EeSxevWRRWxNAg")]
[DisplayName("Mandate")]
public partial record Mandate7
{
    /// <inheritdoc cref="IMandate7.MandateIdentification"/>
    [IsoId("_acF8Nx77EeSxevWRRWxNAg")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public SimpleValueList<IsoMax35Text> MandateIdentification { get; init; } = [];

    /// <inheritdoc cref="IMandate7.MandateRequestIdentification"/>
    [IsoId("_acF8OR77EeSxevWRRWxNAg")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate7.Type"/>
    [IsoId("_acF8Ox77EeSxevWRRWxNAg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation1? Type { get; init; }

    /// <inheritdoc cref="IMandate7.Occurrences"/>
    [IsoId("_acF8PR77EeSxevWRRWxNAg")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences3? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate7.CollectionAmount"/>
    [IsoId("_acF8Px77EeSxevWRRWxNAg")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate7.MaximumAmount"/>
    [IsoId("_acF8QR77EeSxevWRRWxNAg")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate7.Reason"/>
    [IsoId("_kDkMoSL0EeSizvrwx7oJNQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate7.CreditorSchemeIdentification"/>
    [IsoId("_acF8Qx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification43? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate7.Creditor"/>
    [IsoId("_acF8RR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification43 Creditor { get; init; }

    /// <inheritdoc cref="IMandate7.CreditorAccount"/>
    [IsoId("_acF8Rx77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate7.CreditorAgent"/>
    [IsoId("_acF8SR77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate7.UltimateCreditor"/>
    [IsoId("_acF8Sx77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate7.Debtor"/>
    [IsoId("_acF8TR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification43 Debtor { get; init; }

    /// <inheritdoc cref="IMandate7.DebtorAccount"/>
    [IsoId("_acF8Tx77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount24? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate7.DebtorAgent"/>
    [IsoId("_acF8UR77EeSxevWRRWxNAg")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification5 DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate7.UltimateDebtor"/>
    [IsoId("_acF8Ux77EeSxevWRRWxNAg")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate7.ReferredDocument"/>
    [IsoId("_acF8VR77EeSxevWRRWxNAg")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredDocumentInformation6> ReferredDocument { get; init; } = [];

    /// <inheritdoc cref="IMandate7.SupplementaryData"/>
    [IsoId("_acF8Vx77EeSxevWRRWxNAg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
