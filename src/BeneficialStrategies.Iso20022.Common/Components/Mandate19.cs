// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate19"/>
[IsoId("_fdUzYdcZEeqRFcf2R4bPBw")]
[DisplayName("Mandate")]
public partial record Mandate19
{
    /// <inheritdoc cref="IMandate19.MandateIdentification"/>
    [IsoId("_feuhldcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public SimpleValueList<IsoMax35Text> MandateIdentification { get; init; } = [];

    /// <inheritdoc cref="IMandate19.MandateRequestIdentification"/>
    [IsoId("_feuhl9cZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate19.Authentication"/>
    [IsoId("_feuhmdcZEeqRFcf2R4bPBw")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <inheritdoc cref="IMandate19.Type"/>
    [IsoId("_feuhm9cZEeqRFcf2R4bPBw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <inheritdoc cref="IMandate19.Occurrences"/>
    [IsoId("_feuhndcZEeqRFcf2R4bPBw")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences5? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate19.TrackingIndicator"/>
    [IsoId("_feuhn9cZEeqRFcf2R4bPBw")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <inheritdoc cref="IMandate19.FirstCollectionAmount"/>
    [IsoId("_feuhodcZEeqRFcf2R4bPBw")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate19.CollectionAmount"/>
    [IsoId("_feuho9cZEeqRFcf2R4bPBw")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate19.MaximumAmount"/>
    [IsoId("_feuhpdcZEeqRFcf2R4bPBw")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate19.Adjustment"/>
    [IsoId("_feuhp9cZEeqRFcf2R4bPBw")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <inheritdoc cref="IMandate19.Reason"/>
    [IsoId("_feuhqdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate19.CreditorSchemeIdentification"/>
    [IsoId("_feuhq9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate19.Creditor"/>
    [IsoId("_feuhrdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IMandate19.CreditorAccount"/>
    [IsoId("_feuhr9cZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate19.CreditorAgent"/>
    [IsoId("_feuhsdcZEeqRFcf2R4bPBw")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate19.UltimateCreditor"/>
    [IsoId("_feuhs9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate19.Debtor"/>
    [IsoId("_feuhtdcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IMandate19.DebtorAccount"/>
    [IsoId("_feuht9cZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate19.DebtorAgent"/>
    [IsoId("_feuhudcZEeqRFcf2R4bPBw")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate19.UltimateDebtor"/>
    [IsoId("_feuhu9cZEeqRFcf2R4bPBw")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate19.MandateReference"/>
    [IsoId("_feuhvdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateReference { get; init; }

    /// <inheritdoc cref="IMandate19.ReferredDocument"/>
    [IsoId("_feuhv9cZEeqRFcf2R4bPBw")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredMandateDocument1> ReferredDocument { get; init; } = [];

    /// <inheritdoc cref="IMandate19.SupplementaryData"/>
    [IsoId("_feuhwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
