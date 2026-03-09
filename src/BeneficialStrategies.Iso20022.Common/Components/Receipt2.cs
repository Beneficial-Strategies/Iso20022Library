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
[IsoId("_SoDHcZIdEeect698_YsnIA")]
[DisplayName("Receipt")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Receipt2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Receipt2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Receipt2( OriginalMessageAndIssuer1 reqOriginalMessageIdentification )
    {
        OriginalMessageIdentification = reqOriginalMessageIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the original request message.
    /// </summary>
    [IsoId("_SyVr45IdEeect698_YsnIA")]
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
    /// Identification of the original transaction identification, when the request for which the receipt is generated is a payment transaction.
    /// </summary>
    [IsoId("_W_fBwJIdEeect698_YsnIA")]
    [DisplayName("Original Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtId")]
    #endif
    [IsoXmlTag("OrgnlPmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentIdentification5Choice_? OriginalPaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification5Choice_? OriginalPaymentIdentification { get; init; } 
    #else
    public PaymentIdentification5Choice_? OriginalPaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Gives the status of the request.
    /// </summary>
    [IsoId("_SyVr5ZIdEeect698_YsnIA")]
    [DisplayName("Request Handling")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqHdlg")]
    #endif
    [IsoXmlTag("ReqHdlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequestHandling1? RequestHandling { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestHandling1? RequestHandling { get; init; } 
    #else
    public RequestHandling1? RequestHandling { get; set; } 
    #endif
    
    
    #nullable disable
    
}
