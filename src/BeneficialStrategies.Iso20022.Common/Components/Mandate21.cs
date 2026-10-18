// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate21"/>
[IsoId("_yR4OUTEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate21")]
public partial record Mandate21
{
    /// <inheritdoc cref="IMandate21.Adjustment"/>
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <inheritdoc cref="IMandate21.Authentication"/>
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <inheritdoc cref="IMandate21.CollectionAmount"/>
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate21.Creditor"/>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification272? Creditor { get; init; }

    /// <inheritdoc cref="IMandate21.CreditorAccount"/>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate21.CreditorAgent"/>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate21.CreditorSchemeIdentification"/>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate21.Debtor"/>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification272? Debtor { get; init; }

    /// <inheritdoc cref="IMandate21.DebtorAccount"/>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate21.DebtorAgent"/>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate21.FirstCollectionAmount"/>
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate21.MandateIdentification"/>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandate21.MandateReference"/>
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    public IsoMax35Text? MandateReference { get; init; }

    /// <inheritdoc cref="IMandate21.MandateRequestIdentification"/>
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate21.MaximumAmount"/>
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate21.Occurrences"/>
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences5? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate21.Reason"/>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate21.ReferredDocument"/>
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredMandateDocument2> ReferredDocument { get; init; } = [];

    /// <inheritdoc cref="IMandate21.TrackingIndicator"/>
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <inheritdoc cref="IMandate21.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <inheritdoc cref="IMandate21.UltimateCreditor"/>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate21.UltimateDebtor"/>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }
}
