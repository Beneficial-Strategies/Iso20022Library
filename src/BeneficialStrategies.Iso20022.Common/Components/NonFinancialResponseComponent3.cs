// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to a non financial request.
/// </summary>
[IsoId("_HyDDEXJZEe299ZbWCkdR_w")]
[DisplayName("Non Financial Response Component")]
public partial record NonFinancialResponseComponent3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_H4gQYXJZEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment79 Environment { get; init; } 
    
    /// <summary>
    /// Response of the non financial request.
    /// </summary>
    [IsoId("_H4gQY3JZEe299ZbWCkdR_w")]
    [DisplayName("Response Content")]
    [IsoXmlTag("RspnCntt")]
    public ValueList<NonFinancialResponseContentComponent3> ResponseContent { get; init; } = [];
    // ID for the above is _H4gQY3JZEe299ZbWCkdR_w
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_H4isoXJZEe299ZbWCkdR_w")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType11 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_H4iso3JZEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
