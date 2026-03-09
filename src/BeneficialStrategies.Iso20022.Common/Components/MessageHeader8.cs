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
/// Set of characteristics, such as the identification or the creation date and time, specific to the message.
/// </summary>
[IsoId("_i375p5IhEeect698_YsnIA")]
[DisplayName("Message Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageHeader8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageHeader8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageHeader8( System.String reqMessageIdentification )
    {
        MessageIdentification = reqMessageIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the sender, to unambiguously identify the message.|Usage: The sender has to make sure that MessageIdentification is unique for a pre-agreed period.
    /// </summary>
    [IsoId("_jATLc5IhEeect698_YsnIA")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageIdentification { get; init; } 
    #else
    public System.String MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_jATLdZIhEeect698_YsnIA")]
    [DisplayName("Creation Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CreDtTm")]
    #endif
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? CreationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? CreationDateTime { get; init; } 
    #else
    public System.DateTime? CreationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Pagination of the message.|Usage: the pagination of the message is only allowed when agreed between the parties.
    /// </summary>
    [IsoId("_jATLd5IhEeect698_YsnIA")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? MessagePagination { get; init; } 
    #else
    public Pagination1? MessagePagination { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the original query message.
    /// </summary>
    [IsoId("_jATLeZIhEeect698_YsnIA")]
    [DisplayName("Original Business Query")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlBizQry")]
    #endif
    [IsoXmlTag("OrgnlBizQry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; init; } 
    #else
    public OriginalBusinessQuery1? OriginalBusinessQuery { get; set; } 
    #endif
    
    /// <summary>
    /// Specific actions to be executed through the request.
    /// </summary>
    [IsoId("_jATLe5IhEeect698_YsnIA")]
    [DisplayName("Request Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqTp")]
    #endif
    [IsoXmlTag("ReqTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RequestType4Choice_? RequestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestType4Choice_? RequestType { get; init; } 
    #else
    public RequestType4Choice_? RequestType { get; set; } 
    #endif
    
    /// <summary>
    /// Recalls the criteria (search and return criteria) defined in a preceding query.
    /// </summary>
    [IsoId("_jATLfZIhEeect698_YsnIA")]
    [DisplayName("Query Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryNm")]
    #endif
    [IsoXmlTag("QryNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryName { get; init; } 
    #else
    public System.String? QueryName { get; set; } 
    #endif
    
    
    #nullable disable
    
}
