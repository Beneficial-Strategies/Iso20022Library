// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of elements which specify the opening of a non deliverable trade.
/// </summary>
[IsoId("_U8POidp-Ed-ak6NoX_4Aeg_328638139")]
[DisplayName("Opening Data")]
public record OpeningData2
{
    /// <summary>
    /// Date at which the trading parties execute a treasury trade.
    /// </summary>
    [IsoId("_U8POitp-Ed-ak6NoX_4Aeg_328638141")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; }

    /// <summary>
    /// Refers to the identification of a notification assigned by the trading side.
    /// </summary>
    [IsoId("_U8Y_gNp-Ed-ak6NoX_4Aeg_328638191")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; }

    /// <summary>
    /// Reference common to the parties of a trade.
    /// </summary>
    [IsoId("_U8Y_gdp-Ed-ak6NoX_4Aeg_328638156")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; }

    /// <summary>
    /// Refers to the identification of a previous event in the life of a non deliverable forward trade.
    /// </summary>
    [IsoId("_U8Y_gtp-Ed-ak6NoX_4Aeg_328638426")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RelatedReference { get; init; }

    /// <summary>
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_U8Y_g9p-Ed-ak6NoX_4Aeg_328638451")]
    [DisplayName("Amend Or Cancel Reason")]
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AmendOrCancelReason { get; init; }

    /// <summary>
    /// Specifies the amounts of the non deliverable trade which is reported.
    /// </summary>
    [IsoId("_U8Y_hNp-Ed-ak6NoX_4Aeg_328638532")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }

    /// <summary>
    /// Exchange rate between two currencies. The rate is agreed by the trading parties during the negotiation process.
    /// </summary>
    [IsoId("_U8Y_hdp-Ed-ak6NoX_4Aeg_328638564")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public required AgreedRate1 AgreedRate { get; init; }

    /// <summary>
    /// Set of parameters used to calculate the valuation rate to be applied to a non-deliverable agreement.
    /// </summary>
    [IsoId("_U8Y_htp-Ed-ak6NoX_4Aeg_328638582")]
    [DisplayName("Valuation Conditions")]
    [IsoXmlTag("ValtnConds")]
    public required NonDeliverableForwardValuationConditions2 ValuationConditions { get; init; }
}
