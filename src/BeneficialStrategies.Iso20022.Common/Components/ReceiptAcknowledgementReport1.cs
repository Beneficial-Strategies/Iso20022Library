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
/// Provides details on the original request. Identifies the message being acknowledged and its status.
/// </summary>
[IsoId("_jHt69O5NEeCisYr99QEiWA_-1586267634")]
[DisplayName("Receipt Acknowledgement Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReceiptAcknowledgementReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReceiptAcknowledgementReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReceiptAcknowledgementReport1( AdditionalReferences reqRelatedReference,RequestHandling1 reqRequestHandling )
    {
        RelatedReference = reqRelatedReference;
        RequestHandling = reqRequestHandling;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of the request.
    /// </summary>
    [IsoId("_jH3E4O5NEeCisYr99QEiWA_-1954136940")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReferences RelatedReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReferences RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReferences RelatedReference { get; init; } 
    #else
    public AdditionalReferences RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_jH3E4e5NEeCisYr99QEiWA_-375245615")]
    [DisplayName("Request Handling")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqHdlg")]
    #endif
    [IsoXmlTag("ReqHdlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestHandling1 RequestHandling { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequestHandling1 RequestHandling { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestHandling1 RequestHandling { get; init; } 
    #else
    public RequestHandling1 RequestHandling { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original message for which the acknowledgement is sent.
    /// </summary>
    [IsoId("_jH3E4u5NEeCisYr99QEiWA_-864664947")]
    [DisplayName("Original Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgId")]
    #endif
    [IsoXmlTag("OrgnlMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification6? OriginalMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification6? OriginalMessageIdentification { get; init; } 
    #else
    public MessageIdentification6? OriginalMessageIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
