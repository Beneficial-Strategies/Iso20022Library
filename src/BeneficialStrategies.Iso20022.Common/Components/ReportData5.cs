// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numerical representation of the nett increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
/// </summary>
[IsoId("_tziaQTqeEeKqTf3MbquCbA")]
[DisplayName("Report Data")]
public partial record ReportData5
{
    #nullable enable
    
    /// <summary>
    /// Identification of the report assigned by the central system.
    /// </summary>
    [IsoId("_t_XPwTqeEeKqTf3MbquCbA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Date by which the amount(s) requested must be settled.
    /// </summary>
    [IsoId("_t_XPxTqeEeKqTf3MbquCbA")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Date and time on which the report is generated. The offset with UTC may also be specified.
    /// </summary>
    [IsoId("_t_XPyTqeEeKqTf3MbquCbA")]
    [DisplayName("Date And Time Stamp")]
    [IsoXmlTag("DtAndTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateAndTimeStamp { get; init; } 
    
    /// <summary>
    /// Specifies the type of the Pay In Call.
    /// </summary>
    [IsoId("_t_XPzTqeEeKqTf3MbquCbA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CallIn1Code Type { get; init; } 
    
    /// <summary>
    /// Specifies the amount requested.
    /// </summary>
    [IsoId("_t_XP0TqeEeKqTf3MbquCbA")]
    [DisplayName("Pay In Call Amount")]
    [IsoXmlTag("PayInCallAmt")]
    public PayInCallItem? PayInCallAmount { get; init; } 
    
    /// <summary>
    /// To indicate the requested CLS Settlement Session that the related trade is part of.
    /// </summary>
    [IsoId("_wIyaaTqeEeKqTf3MbquCbA")]
    [DisplayName("Settlement Session Identifier")]
    [IsoXmlTag("SttlmSsnIdr")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    public IsoExact4AlphaNumericText? SettlementSessionIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies the requested amount in multiple currencies.
    /// </summary>
    [IsoId("_t_XP1TqeEeKqTf3MbquCbA")]
    [DisplayName("Account Value")]
    [IsoXmlTag("AcctVal")]
    public Value? AccountValue { get; init; } 
    
    
    #nullable disable
    
}
