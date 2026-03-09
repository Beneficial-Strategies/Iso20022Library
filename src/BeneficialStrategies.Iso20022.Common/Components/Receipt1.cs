// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the request.
/// </summary>
[IsoId("_746ppqMgEeCJ6YNENx4h-w_-1799961692")]
[DisplayName("Receipt")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Receipt1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Receipt1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Receipt1( OriginalMessageAndIssuer1 reqOriginalMessageIdentification )
    {
        OriginalMessageIdentification = reqOriginalMessageIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the original request message.
    /// </summary>
    [IsoId("_746pp6MgEeCJ6YNENx4h-w_-1913800758")]
    [DisplayName("Original Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgId")]
    #endif
    [IsoXmlTag("OrgnlMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalMessageAndIssuer1 OriginalMessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalMessageAndIssuer1 OriginalMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalMessageAndIssuer1 OriginalMessageIdentification { get; init; } 
    #else
    public OriginalMessageAndIssuer1 OriginalMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_75DzkKMgEeCJ6YNENx4h-w_1497933251")]
    [DisplayName("Request Handling")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqHdlg")]
    #endif
    [IsoXmlTag("ReqHdlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequestHandling? RequestHandling { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestHandling? RequestHandling { get; init; } 
    #else
    public RequestHandling? RequestHandling { get; set; } 
    #endif
    
    
    #nullable disable
    
}
