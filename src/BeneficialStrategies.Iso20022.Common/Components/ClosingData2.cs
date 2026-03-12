// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of data specified for the fixing of a non deliverable trade.
/// </summary>
[IsoId("_THtV2Np-Ed-ak6NoX_4Aeg_855669497")]
[DisplayName("Closing Data")]
public partial record ClosingData2
{
    #nullable enable
    
    /// <summary>
    /// Date at which the trading parties have agreed on a valuation rate for a non deliverable trade.
    /// </summary>
    [IsoId("_TH3G0Np-Ed-ak6NoX_4Aeg_855669499")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Refers to the identification of a trade assigned by the trading side of a non deliverable forward trade.
    /// </summary>
    [IsoId("_TH3G0dp-Ed-ak6NoX_4Aeg_863054176")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Reference common to the parties of a trade.
    /// </summary>
    [IsoId("_TH3G0tp-Ed-ak6NoX_4Aeg_855669540")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; } 
    
    /// <summary>
    /// Refers to the identification of a previous event in the life of a non deliverable forward trade.
    /// </summary>
    [IsoId("_TH3G09p-Ed-ak6NoX_4Aeg_863054236")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedReference { get; init; } 
    
    /// <summary>
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_TH3G1Np-Ed-ak6NoX_4Aeg_863054211")]
    [DisplayName("Amend Or Cancel Reason")]
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AmendOrCancelReason { get; init; } 
    
    /// <summary>
    /// Specifies the amounts traded at the valuation of a non-deliverable trade.
    /// </summary>
    [IsoId("_TH3G1dp-Ed-ak6NoX_4Aeg_863054332")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; } 
    
    /// <summary>
    /// Rate obtained at valuation time by following the valuation conditions (agreed upon by the trading parties at the opening of the non-deliverable contract).
    /// </summary>
    [IsoId("_TH3G1tp-Ed-ak6NoX_4Aeg_863054297")]
    [DisplayName("Valuation Rate")]
    [IsoXmlTag("ValtnRate")]
    public required AgreedRate1 ValuationRate { get; init; } 
    
    /// <summary>
    /// Set of parameters used to calculate the valuation rate to be applied to a non-deliverable agreement.
    /// </summary>
    [IsoId("_TH3G19p-Ed-ak6NoX_4Aeg_863054272")]
    [DisplayName("Valuation Information")]
    [IsoXmlTag("ValtnInf")]
    public required ValuationData2 ValuationInformation { get; init; } 
    
    
    #nullable disable
    
}
