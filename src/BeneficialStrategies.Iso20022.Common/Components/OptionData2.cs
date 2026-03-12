// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of data which contains the link to a previously notified option trade.
/// </summary>
[IsoId("_U8r6ddp-Ed-ak6NoX_4Aeg_254982681")]
[DisplayName("Option Data")]
public partial record OptionData2
{
    #nullable enable
    
    /// <summary>
    /// Date at which the trading parties have agreed on an option trade.
    /// </summary>
    [IsoId("_U8r6dtp-Ed-ak6NoX_4Aeg_254982700")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Refers to the identification of a trade assigned by the trading side of a foreign exchange option trade.
    /// </summary>
    [IsoId("_U8r6d9p-Ed-ak6NoX_4Aeg_254982734")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Reference common to the parties of a trade.
    /// </summary>
    [IsoId("_U8r6eNp-Ed-ak6NoX_4Aeg_254982716")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; } 
    
    /// <summary>
    /// Refers to the identification of a previous event in the life of a foreign exchange option trade.
    /// </summary>
    [IsoId("_U8r6edp-Ed-ak6NoX_4Aeg_254982776")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedReference { get; init; } 
    
    /// <summary>
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_U81EYNp-Ed-ak6NoX_4Aeg_254982759")]
    [DisplayName("Amend Or Cancel Reason")]
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AmendOrCancelReason { get; init; } 
    
    /// <summary>
    /// Set of data defining a foreign exchange option sold.
    /// </summary>
    [IsoId("_U81EYdp-Ed-ak6NoX_4Aeg_254982826")]
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public required Option3 Option { get; init; } 
    
    
    #nullable disable
    
}
