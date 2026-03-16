// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria which are used to search for standing orders defined within the system.
/// </summary>
[IsoId("_ge92mdcZEeqRFcf2R4bPBw")]
[DisplayName("Standing Order Search Criteria")]
public record StandingOrderSearchCriteria4
{
    /// <summary>
    /// Indicates whether the key fields or business attributes defined within the system must be returned.
    /// </summary>
    [IsoId("_ggWWodcZEeqRFcf2R4bPBw")]
    [DisplayName("Key Attributes Indicator")]
    [IsoXmlTag("KeyAttrbtsInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? KeyAttributesIndicator { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify the standing order used to initiate the liquidity transfer.
    /// </summary>
    [IsoId("_ggWWo9cZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Identification")]
    [IsoXmlTag("StgOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StandingOrderIdentification { get; init; }

    /// <summary>
    /// Type of the standing order.
    /// </summary>
    [IsoId("_ggWWpdcZEeqRFcf2R4bPBw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public StandingOrderType1Choice_? Type { get; init; }

    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [IsoId("_ggWWp9cZEeqRFcf2R4bPBw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public CashAccount40? Account { get; init; }

    /// <summary>
    /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
    /// </summary>
    [IsoId("_ggWWqdcZEeqRFcf2R4bPBw")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Dates during which the standing order is in effect.
    /// </summary>
    [IsoId("_ggWWq9cZEeqRFcf2R4bPBw")]
    [DisplayName("Validity Period")]
    [IsoXmlTag("VldtyPrd")]
    public DatePeriod2Choice_? ValidityPeriod { get; init; }

    /// <summary>
    /// Specifies if the account is debited or credited by the standing order.
    /// </summary>
    [IsoId("_ggWWrdcZEeqRFcf2R4bPBw")]
    [DisplayName("System Member")]
    [IsoXmlTag("SysMmb")]
    public BranchAndFinancialInstitutionIdentification6? SystemMember { get; init; }

    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_ggWWr9cZEeqRFcf2R4bPBw")]
    [DisplayName("Responsible Party")]
    [IsoXmlTag("RspnsblPty")]
    public BranchAndFinancialInstitutionIdentification6? ResponsibleParty { get; init; }

    /// <summary>
    /// Liquidity transfer origin or destination account within the pool of accounts under management of the requestor.
    /// </summary>
    [IsoId("_ggWWsdcZEeqRFcf2R4bPBw")]
    [DisplayName("Associated Pool Account")]
    [IsoXmlTag("AssoctdPoolAcct")]
    public AccountIdentification4Choice_? AssociatedPoolAccount { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify the link set in which the standing order is defined. The link set is a collection of standing order defined in a specific sequence.
    /// </summary>
    [IsoId("_ggWWs9cZEeqRFcf2R4bPBw")]
    [DisplayName("Link Set Identification")]
    [IsoXmlTag("LkSetId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LinkSetIdentification { get; init; }

    /// <summary>
    /// Unique identification to unambiguously identify liquidity transfer standing order within the link set.
    /// </summary>
    [IsoId("_ggWWtdcZEeqRFcf2R4bPBw")]
    [DisplayName("Link Set Order Identification")]
    [IsoXmlTag("LkSetOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? LinkSetOrderIdentification { get; init; }

    /// <summary>
    /// Specifies the sequence in which the system will execute the liquidity transfers standing order within the link set when additional liquidity is required.
    /// </summary>
    [IsoId("_ggWWt9cZEeqRFcf2R4bPBw")]
    [DisplayName("Link Set Order Sequence")]
    [IsoXmlTag("LkSetOrdrSeq")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? LinkSetOrderSequence { get; init; }

    /// <summary>
    /// Indicates whether the query shall return all liquidity transfer standing orders defined as zero sweeping orders.
    /// When the indicator is set to true, the liquidity transfer standing order will transfer all amount of money out of the account so the resulting balance is zero.
    /// </summary>
    [IsoId("_ggWWudcZEeqRFcf2R4bPBw")]
    [DisplayName("Zero Sweep Indicator")]
    [IsoXmlTag("ZeroSweepInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ZeroSweepIndicator { get; init; }
}
