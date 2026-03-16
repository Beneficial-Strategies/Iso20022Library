// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate23.
/// </summary>
[IsoId("_3-qx0TEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate23")]
public record Mandate23
{
    /// <summary>
    /// Adjustment.
    /// </summary>
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <summary>
    /// Authentication.
    /// </summary>
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <summary>
    /// Collection Amount.
    /// </summary>
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification272 Creditor { get; init; }

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; }

    /// <summary>
    /// Creditor Agent.
    /// </summary>
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification8? CreditorAgent { get; init; }

    /// <summary>
    /// Creditor Scheme Identification.
    /// </summary>
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification272? CreditorSchemeIdentification { get; init; }

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Debtor Agent.
    /// </summary>
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <summary>
    /// First Collection Amount.
    /// </summary>
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <summary>
    /// Mandate Identification.
    /// </summary>
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public ValueList<IsoMax35Text> MandateIdentification { get; init; } = [];

    /// <summary>
    /// Mandate Reference.
    /// </summary>
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    public IsoMax35Text? MandateReference { get; init; }

    /// <summary>
    /// Mandate Request Identification.
    /// </summary>
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    public required IsoMax35Text MandateRequestIdentification { get; init; }

    /// <summary>
    /// Maximum Amount.
    /// </summary>
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <summary>
    /// Occurrences.
    /// </summary>
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences5? Occurrences { get; init; }

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <summary>
    /// Referred Document.
    /// </summary>
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredMandateDocument2> ReferredDocument { get; init; } = [];

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Tracking Indicator.
    /// </summary>
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <summary>
    /// Ultimate Creditor.
    /// </summary>
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification272? UltimateCreditor { get; init; }

    /// <summary>
    /// Ultimate Debtor.
    /// </summary>
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }
}
