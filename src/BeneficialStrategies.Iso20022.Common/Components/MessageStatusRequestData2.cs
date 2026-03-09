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
/// Content of the Message TransactionStatus Request message.
/// </summary>
[IsoId("_QFd_4Q03EeqUVL7sB4m7NA")]
[DisplayName("Message Status Request Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageStatusRequestData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageStatusRequestData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageStatusRequestData2( System.String reqExchangeIdentification,GenericIdentification177 reqInitiatingParty )
    {
        ExchangeIdentification = reqExchangeIdentification;
        InitiatingParty = reqInitiatingParty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Transaction identification.
    /// </summary>
    [IsoId("_QRlwUQ03EeqUVL7sB4m7NA")]
    [DisplayName("Exchange Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgId")]
    #endif
    [IsoXmlTag("XchgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ExchangeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExchangeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExchangeIdentification { get; init; } 
    #else
    public System.String ExchangeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Initiating Party information.
    /// </summary>
    [IsoId("_QRlwUw03EeqUVL7sB4m7NA")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification177 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification177 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification177 InitiatingParty { get; init; } 
    #else
    public GenericIdentification177 InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Request to reprint the POI receipt(s).
    /// </summary>
    [IsoId("_QRlwVQ03EeqUVL7sB4m7NA")]
    [DisplayName("Receipt Reprint Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RctRprntFlg")]
    #endif
    [IsoXmlTag("RctRprntFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ReceiptReprintFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReceiptReprintFlag { get; init; } 
    #else
    public System.String? ReceiptReprintFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Customer or Cashier Receipt.
    /// </summary>
    [IsoId("_QRlwVw03EeqUVL7sB4m7NA")]
    [DisplayName("Document Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocQlfr")]
    #endif
    [IsoXmlTag("DocQlfr")]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<DocumentType7Code> DocumentQualifier { get; init; } = new SimpleValueList<DocumentType7Code>(){};
    
    
    #nullable disable
    
}
