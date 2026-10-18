// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate20"/>
[IsoId("_yPqnozEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate20")]
public partial record Mandate20
{
    /// <inheritdoc cref="IMandate20.Adjustment"/>
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <inheritdoc cref="IMandate20.Authentication"/>
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <inheritdoc cref="IMandate20.CollectionAmount"/>
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate20.Creditor"/>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <inheritdoc cref="IMandate20.CreditorAccount"/>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate20.CreditorAgent"/>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate20.CreditorSchemeIdentification"/>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate20.Debtor"/>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <inheritdoc cref="IMandate20.DebtorAccount"/>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate20.DebtorAgent"/>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate20.FirstCollectionAmount"/>
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate20.MandateIdentification"/>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandate20.MandateReference"/>
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    public IsoMax35Text? MandateReference { get; init; }

    /// <inheritdoc cref="IMandate20.MandateRequestIdentification"/>
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate20.MaximumAmount"/>
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate20.Occurrences"/>
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences5? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate20.Reason"/>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate20.ReferredDocument"/>
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredMandateDocument2> ReferredDocument { get; init; } = [];

    /// <inheritdoc cref="IMandate20.TrackingIndicator"/>
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <inheritdoc cref="IMandate20.Type"/>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <inheritdoc cref="IMandate20.UltimateCreditor"/>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate20.UltimateDebtor"/>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }
}
