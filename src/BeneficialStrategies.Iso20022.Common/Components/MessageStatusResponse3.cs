// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// This component define the environment, the context
/// and the services to be used with this message.
/// </summary>
[IsoId("_a91QkQ03EeqUVL7sB4m7NA")]
[DisplayName("Message Status Response")]
public partial record MessageStatusResponse3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_bJpfAQ03EeqUVL7sB4m7NA")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required CardPaymentEnvironment75 Environment { get; init; } 
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_bJpfAw03EeqUVL7sB4m7NA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required CardPaymentContext28 Context { get; init; } 
    
    /// <summary>
    /// Content of the Message status Response.
    /// </summary>
    [IsoId("_bJpfBQ03EeqUVL7sB4m7NA")]
    [DisplayName("Message Status Response Data")]
    [IsoXmlTag("MsgStsRspnData")]
    public required MessageStatusResponseData3 MessageStatusResponseData { get; init; } 
    
    /// <summary>
    /// Result of the processing of the request.
    /// </summary>
    [IsoId("_bJpfBw03EeqUVL7sB4m7NA")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required ResponseType9 Response { get; init; } 
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_bJpfCQ03EeqUVL7sB4m7NA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
