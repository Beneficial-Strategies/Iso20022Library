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
/// Unique identification, as assigned by the first instructing agent, to unambiguously identify the group of transactions.
/// </summary>
[IsoId("_RrBVYtp-Ed-ak6NoX_4Aeg_884871107")]
[DisplayName("Underlying Group Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingGroupInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UnderlyingGroupInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UnderlyingGroupInformation1( System.String reqOriginalMessageIdentification,System.String reqOriginalMessageNameIdentification )
    {
        OriginalMessageIdentification = reqOriginalMessageIdentification;
        OriginalMessageNameIdentification = reqOriginalMessageNameIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original instructing party, to unambiguously identify the original message.
    /// </summary>
    [IsoId("_RrBVY9p-Ed-ak6NoX_4Aeg_884871138")]
    [DisplayName("Original Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgId")]
    #endif
    [IsoXmlTag("OrgnlMsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalMessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalMessageIdentification { get; init; } 
    #else
    public System.String OriginalMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_RrBVZNp-Ed-ak6NoX_4Aeg_884871169")]
    [DisplayName("Original Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgNmId")]
    #endif
    [IsoXmlTag("OrgnlMsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OriginalMessageNameIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OriginalMessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OriginalMessageNameIdentification { get; init; } 
    #else
    public System.String OriginalMessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the original message was created.
    /// </summary>
    [IsoId("_RrBVZdp-Ed-ak6NoX_4Aeg_884871199")]
    [DisplayName("Original Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlCreDtTm")]
    #endif
    [IsoXmlTag("OrgnlCreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? OriginalCreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? OriginalCreationDateTime { get; init; } 
    #else
    public System.DateTime? OriginalCreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Original channel used for the delivery of the message, to allow the receiver of the request to locate the payment with greater ease.
    /// </summary>
    [IsoId("_RrBVZtp-Ed-ak6NoX_4Aeg_1113343746")]
    [DisplayName("Original Message Delivery Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlMsgDlvryChanl")]
    #endif
    [IsoXmlTag("OrgnlMsgDlvryChanl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalMessageDeliveryChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalMessageDeliveryChannel { get; init; } 
    #else
    public System.String? OriginalMessageDeliveryChannel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
