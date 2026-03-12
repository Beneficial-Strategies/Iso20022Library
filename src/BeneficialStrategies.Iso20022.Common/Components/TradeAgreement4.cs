// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and identification of a trade together with references to previous events in its life.
/// </summary>
[IsoId("_TJzAgtp-Ed-ak6NoX_4Aeg_-331393042")]
[DisplayName("Trade Agreement")]
public partial record TradeAgreement4
{
    #nullable enable
    
    /// <summary>
    /// Date on which the trading parties agree to amend or cancel the trade.
    /// </summary>
    [IsoId("_TJzAg9p-Ed-ak6NoX_4Aeg_-331393011")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Identification of the notification.This identification must be unique amongst all notifications of same type confirmed by the same party.
    /// </summary>
    [IsoId("_TJzAhNp-Ed-ak6NoX_4Aeg_-331392889")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Reference common to both parties of the trade.
    /// </summary>
    [IsoId("_TJzAhdp-Ed-ak6NoX_4Aeg_-331392981")]
    [DisplayName("Common Reference")]
    [IsoXmlTag("CmonRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CommonReference { get; init; } 
    
    /// <summary>
    /// Describes the reason for the cancellation or the amendment.
    /// </summary>
    [IsoId("_TJzAhtp-Ed-ak6NoX_4Aeg_-331392919")]
    [DisplayName("Amend Or Cancel Reason")]
    [IsoXmlTag("AmdOrCclRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AmendOrCancelReason { get; init; } 
    
    /// <summary>
    /// Refers to the identification of a previous event in the life of a trade which is amended or cancelled.
    /// </summary>
    [IsoId("_TJzAh9p-Ed-ak6NoX_4Aeg_-331392950")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RelatedReference { get; init; } 
    
    /// <summary>
    /// Specifies the type of underlying transaction, for example, option.
    /// </summary>
    [IsoId("_TJzAiNp-Ed-ak6NoX_4Aeg_64531856")]
    [DisplayName("Operation Type")]
    [IsoXmlTag("OprTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? OperationType { get; init; } 
    
    /// <summary>
    /// Specifies the business role between the submitter and the trade party, for example Agent (AGNT).
    /// </summary>
    [IsoId("_TJ8xgNp-Ed-ak6NoX_4Aeg_68227811")]
    [DisplayName("Operation Scope")]
    [IsoXmlTag("OprScp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? OperationScope { get; init; } 
    
    
    #nullable disable
    
}
