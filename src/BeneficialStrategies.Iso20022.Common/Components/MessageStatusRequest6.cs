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
/// Contents information to identify a previous exchange. 
/// </summary>
[IsoId("_kfBrQXJhEe299ZbWCkdR_w")]
[DisplayName("Message Status Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageStatusRequest6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageStatusRequest6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageStatusRequest6( CardPaymentEnvironment79 reqEnvironment,CardPaymentContext30 reqContext,MessageStatusRequestData2 reqMessageStatusRequestData )
    {
        Environment = reqEnvironment;
        Context = reqContext;
        MessageStatusRequestData = reqMessageStatusRequestData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_klgtwXJhEe299ZbWCkdR_w")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment79 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment79 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment79 Environment { get; init; } 
    #else
    public CardPaymentEnvironment79 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    [IsoId("_klgtw3JhEe299ZbWCkdR_w")]
    [DisplayName("Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cntxt")]
    #endif
    [IsoXmlTag("Cntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentContext30 Context { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentContext30 Context { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentContext30 Context { get; init; } 
    #else
    public CardPaymentContext30 Context { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the previous exchange.
    /// </summary>
    [IsoId("_klgtxXJhEe299ZbWCkdR_w")]
    [DisplayName("Message Status Request Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgStsReqData")]
    #endif
    [IsoXmlTag("MsgStsReqData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageStatusRequestData2 MessageStatusRequestData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageStatusRequestData2 MessageStatusRequestData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageStatusRequestData2 MessageStatusRequestData { get; init; } 
    #else
    public MessageStatusRequestData2 MessageStatusRequestData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information incorporated as an extension to the message.
    /// </summary>
    [IsoId("_klgtx3JhEe299ZbWCkdR_w")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
