// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate14"/>
[IsoId("_R8fYrW49EeiU9cctagi5ow")]
[DisplayName("Mandate")]
public partial record Mandate14
{
    /// <inheritdoc cref="IMandate14.MandateIdentification"/>
    [IsoId("_SGUqF249EeiU9cctagi5ow")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateIdentification { get; init; }

    /// <inheritdoc cref="IMandate14.MandateRequestIdentification"/>
    [IsoId("_SGUqGW49EeiU9cctagi5ow")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate14.Authentication"/>
    [IsoId("_SGUqG249EeiU9cctagi5ow")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <inheritdoc cref="IMandate14.Type"/>
    [IsoId("_SGUqHW49EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <inheritdoc cref="IMandate14.Occurrences"/>
    [IsoId("_SGUqH249EeiU9cctagi5ow")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences4? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate14.TrackingIndicator"/>
    [IsoId("_SGUqIW49EeiU9cctagi5ow")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <inheritdoc cref="IMandate14.FirstCollectionAmount"/>
    [IsoId("_SGUqI249EeiU9cctagi5ow")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate14.CollectionAmount"/>
    [IsoId("_SGUqJW49EeiU9cctagi5ow")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate14.MaximumAmount"/>
    [IsoId("_SGUqJ249EeiU9cctagi5ow")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate14.Adjustment"/>
    [IsoId("_SGUqKW49EeiU9cctagi5ow")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <inheritdoc cref="IMandate14.Reason"/>
    [IsoId("_SGUqK249EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate14.CreditorSchemeIdentification"/>
    [IsoId("_SGUqLW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate14.Creditor"/>
    [IsoId("_SGUqL249EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification135? Creditor { get; init; }

    /// <inheritdoc cref="IMandate14.CreditorAccount"/>
    [IsoId("_SGUqMW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate14.CreditorAgent"/>
    [IsoId("_SGUqM249EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate14.UltimateCreditor"/>
    [IsoId("_SGUqNW49EeiU9cctagi5ow")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate14.Debtor"/>
    [IsoId("_SGUqN249EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification135? Debtor { get; init; }

    /// <inheritdoc cref="IMandate14.DebtorAccount"/>
    [IsoId("_SGUqOW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate14.DebtorAgent"/>
    [IsoId("_SGUqO249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate14.UltimateDebtor"/>
    [IsoId("_SGUqPW49EeiU9cctagi5ow")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate14.MandateReference"/>
    [IsoId("_SGUqP249EeiU9cctagi5ow")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateReference { get; init; }

    /// <inheritdoc cref="IMandate14.ReferredDocument"/>
    [IsoId("_SGUqQW49EeiU9cctagi5ow")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredMandateDocument1> ReferredDocument { get; init; } = [];
}
