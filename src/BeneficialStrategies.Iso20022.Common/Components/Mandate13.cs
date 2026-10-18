// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandate13"/>
[IsoId("_Qzd7EW49EeiU9cctagi5ow")]
[DisplayName("Mandate")]
public partial record Mandate13
{
    /// <inheritdoc cref="IMandate13.MandateIdentification"/>
    [IsoId("_Q83Hp249EeiU9cctagi5ow")]
    [DisplayName("Mandate Identification")]
    [IsoXmlTag("MndtId")]
    public SimpleValueList<IsoMax35Text> MandateIdentification { get; init; } = [];

    /// <inheritdoc cref="IMandate13.MandateRequestIdentification"/>
    [IsoId("_Q83HqW49EeiU9cctagi5ow")]
    [DisplayName("Mandate Request Identification")]
    [IsoXmlTag("MndtReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MandateRequestIdentification { get; init; }

    /// <inheritdoc cref="IMandate13.Authentication"/>
    [IsoId("_Q83Hq249EeiU9cctagi5ow")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public MandateAuthentication1? Authentication { get; init; }

    /// <inheritdoc cref="IMandate13.Type"/>
    [IsoId("_Q83HrW49EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public MandateTypeInformation2? Type { get; init; }

    /// <inheritdoc cref="IMandate13.Occurrences"/>
    [IsoId("_Q83Hr249EeiU9cctagi5ow")]
    [DisplayName("Occurrences")]
    [IsoXmlTag("Ocrncs")]
    public MandateOccurrences4? Occurrences { get; init; }

    /// <inheritdoc cref="IMandate13.TrackingIndicator"/>
    [IsoId("_Q83HsW49EeiU9cctagi5ow")]
    [DisplayName("Tracking Indicator")]
    [IsoXmlTag("TrckgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; }

    /// <inheritdoc cref="IMandate13.FirstCollectionAmount"/>
    [IsoId("_Q83Hs249EeiU9cctagi5ow")]
    [DisplayName("First Collection Amount")]
    [IsoXmlTag("FrstColltnAmt")]
    public ActiveCurrencyAndAmount? FirstCollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate13.CollectionAmount"/>
    [IsoId("_Q83HtW49EeiU9cctagi5ow")]
    [DisplayName("Collection Amount")]
    [IsoXmlTag("ColltnAmt")]
    public ActiveCurrencyAndAmount? CollectionAmount { get; init; }

    /// <inheritdoc cref="IMandate13.MaximumAmount"/>
    [IsoId("_Q83Ht249EeiU9cctagi5ow")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ActiveCurrencyAndAmount? MaximumAmount { get; init; }

    /// <inheritdoc cref="IMandate13.Adjustment"/>
    [IsoId("_Q83HuW49EeiU9cctagi5ow")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public MandateAdjustment1? Adjustment { get; init; }

    /// <inheritdoc cref="IMandate13.Reason"/>
    [IsoId("_Q83Hu249EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public MandateSetupReason1Choice_? Reason { get; init; }

    /// <inheritdoc cref="IMandate13.CreditorSchemeIdentification"/>
    [IsoId("_Q83HvW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Scheme Identification")]
    [IsoXmlTag("CdtrSchmeId")]
    public PartyIdentification135? CreditorSchemeIdentification { get; init; }

    /// <inheritdoc cref="IMandate13.Creditor"/>
    [IsoId("_Q83Hv249EeiU9cctagi5ow")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required PartyIdentification135 Creditor { get; init; }

    /// <inheritdoc cref="IMandate13.CreditorAccount"/>
    [IsoId("_Q83HwW49EeiU9cctagi5ow")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount38? CreditorAccount { get; init; }

    /// <inheritdoc cref="IMandate13.CreditorAgent"/>
    [IsoId("_Q83Hw249EeiU9cctagi5ow")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; }

    /// <inheritdoc cref="IMandate13.UltimateCreditor"/>
    [IsoId("_Q83HxW49EeiU9cctagi5ow")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification135? UltimateCreditor { get; init; }

    /// <inheritdoc cref="IMandate13.Debtor"/>
    [IsoId("_Q83Hx249EeiU9cctagi5ow")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification135 Debtor { get; init; }

    /// <inheritdoc cref="IMandate13.DebtorAccount"/>
    [IsoId("_Q83HyW49EeiU9cctagi5ow")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount38? DebtorAccount { get; init; }

    /// <inheritdoc cref="IMandate13.DebtorAgent"/>
    [IsoId("_Q83Hy249EeiU9cctagi5ow")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; }

    /// <inheritdoc cref="IMandate13.UltimateDebtor"/>
    [IsoId("_Q83HzW49EeiU9cctagi5ow")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification135? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IMandate13.MandateReference"/>
    [IsoId("_Q83Hz249EeiU9cctagi5ow")]
    [DisplayName("Mandate Reference")]
    [IsoXmlTag("MndtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MandateReference { get; init; }

    /// <inheritdoc cref="IMandate13.ReferredDocument"/>
    [IsoId("_Q83H0W49EeiU9cctagi5ow")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredMandateDocument1> ReferredDocument { get; init; } = [];

    /// <inheritdoc cref="IMandate13.SupplementaryData"/>
    [IsoId("_Q83H0249EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
