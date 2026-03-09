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
/// Provides details on the original request. Identifies the message being acknowledged and its status
/// </summary>
[IsoId("_WhpTYZb4Eee4htziCyV8eA")]
[DisplayName("Receipt Acknowledgement Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceiptAcknowledgementReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReceiptAcknowledgementReport2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceiptAcknowledgementReport2( MessageReference1 reqRelatedReference,RequestHandling2 reqRequestHandling )
    {
        RelatedReference = reqRelatedReference;
        RequestHandling = reqRequestHandling;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of the request.
    /// </summary>
    [IsoId("_Wrd9wZb4Eee4htziCyV8eA")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageReference1 RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageReference1 RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageReference1 RelatedReference { get; init; } 
    #else
    public MessageReference1 RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_Wrd9w5b4Eee4htziCyV8eA")]
    [DisplayName("Request Handling")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqHdlg")]
    #endif
    [IsoXmlTag("ReqHdlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestHandling2 RequestHandling { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequestHandling2 RequestHandling { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestHandling2 RequestHandling { get; init; } 
    #else
    public RequestHandling2 RequestHandling { get; set; } 
    #endif
    
    
    #nullable disable
    
}
