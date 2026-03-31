// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Standing Order Search Criteria5.
/// </summary>
[IsoId("_0tAz1zEyEe6g-ffJsqGiSA")]
[DisplayName("Standing Order Search Criteria5")]
public record StandingOrderSearchCriteria5
{
    /// <summary>
    /// Account.
    /// </summary>
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Associated Pool Account.
    /// </summary>
    [DisplayName("Associated Pool Account")]
    [IsoXmlTag("AssoctdPoolAcct")]
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; }

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Key Attributes Indicator.
    /// </summary>
    [DisplayName("Key Attributes Indicator")]
    [IsoXmlTag("KeyAttrbtsInd")]
    public IsoTrueFalseIndicator? KeyAttributesIndicator { get; init; }

    /// <summary>
    /// Link Set Identification.
    /// </summary>
    [DisplayName("Link Set Identification")]
    [IsoXmlTag("LkSetId")]
    public IsoMax35Text? LinkSetIdentification { get; init; }

    /// <summary>
    /// Link Set Order Identification.
    /// </summary>
    [DisplayName("Link Set Order Identification")]
    [IsoXmlTag("LkSetOrdrId")]
    public IsoMax35Text? LinkSetOrderIdentification { get; init; }

    /// <summary>
    /// Link Set Order Sequence.
    /// </summary>
    [DisplayName("Link Set Order Sequence")]
    [IsoXmlTag("LkSetOrdrSeq")]
    public IsoNumber? LinkSetOrderSequence { get; init; }

    /// <summary>
    /// Responsible Party.
    /// </summary>
    [DisplayName("Responsible Party")]
    [IsoXmlTag("RspnsblPty")]
    public BranchAndFinancialInstitutionIdentification8? ResponsibleParty { get; init; }

    /// <summary>
    /// Standing Order Identification.
    /// </summary>
    [DisplayName("Standing Order Identification")]
    [IsoXmlTag("StgOrdrId")]
    public IsoMax35Text? StandingOrderIdentification { get; init; }

    /// <summary>
    /// System Member.
    /// </summary>
    [DisplayName("System Member")]
    [IsoXmlTag("SysMmb")]
    public BranchAndFinancialInstitutionIdentification8? SystemMember { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public StandingOrderType1Choice_? Type { get; init; }

    /// <summary>
    /// Validity Period.
    /// </summary>
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public DatePeriod2Choice_? ValidityPeriod { get; init; }

    /// <summary>
    /// Zero Sweep Indicator.
    /// </summary>
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
}
