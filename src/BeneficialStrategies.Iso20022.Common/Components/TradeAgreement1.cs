// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade.
/// </summary>
[IsoId("_TJ8xgdp-Ed-ak6NoX_4Aeg_290674431")]
[DisplayName("Trade Agreement")]
public partial record TradeAgreement1
{
    #nullable enable
    
    /// <summary>
    /// Date at which the trading parties agree on a treasury trade.
    /// </summary>
    [IsoId("_TJ8xgtp-Ed-ak6NoX_4Aeg_290674433")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Identification of a notification.This identification must be unique amongst all notifications of same type confirmed by the same party.
    /// </summary>
    [IsoId("_TJ8xg9p-Ed-ak6NoX_4Aeg_933842643")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Reference common to the parties of a trade.
    /// </summary>
    [IsoId("_TJ8xhNp-Ed-ak6NoX_4Aeg_1033584358")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; } 
    
    
    #nullable disable
    
}
