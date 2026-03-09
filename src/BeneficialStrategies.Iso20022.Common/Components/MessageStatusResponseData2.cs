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
/// Content of the Message status Response.
/// </summary>
[IsoId("_YEAKUYYMEemxIqbaFEE8-w")]
[DisplayName("Message Status Response Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MessageStatusResponseData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MessageStatusResponseData2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MessageStatusResponseData2( System.String reqExchangeIdentification,GenericIdentification171 reqInitiatingParty,ResponseType9 reqTransactionResponse )
    {
        ExchangeIdentification = reqExchangeIdentification;
        InitiatingParty = reqInitiatingParty;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the requested previous message.
    /// </summary>
    [IsoId("_YOXAMYYMEemxIqbaFEE8-w")]
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
    /// Party that has initiated the previous message.
    /// </summary>
    [IsoId("_YOXAM4YMEemxIqbaFEE8-w")]
    [DisplayName("Initiating Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgPty")]
    #endif
    [IsoXmlTag("InitgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification171 InitiatingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification171 InitiatingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification171 InitiatingParty { get; init; } 
    #else
    public GenericIdentification171 InitiatingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specific response of the Repeated Message sent back by the POI System.
    /// </summary>
    [IsoId("_YOXANYYMEemxIqbaFEE8-w")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType9 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType9 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType9 TransactionResponse { get; init; } 
    #else
    public ResponseType9 TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested Loyalty Message Response.
    /// </summary>
    [IsoId("_YOXAN4YMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Loyalty Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpeatdLltyRspn")]
    #endif
    [IsoXmlTag("RpeatdLltyRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyResponse1? RepeatedLoyaltyResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyResponse1? RepeatedLoyaltyResponse { get; init; } 
    #else
    public LoyaltyResponse1? RepeatedLoyaltyResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested Payment Message Response.
    /// </summary>
    [IsoId("_YOXAOYYMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Payment Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpeatdPmtRspn")]
    #endif
    [IsoXmlTag("RpeatdPmtRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentResponse1? RepeatedPaymentResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentResponse1? RepeatedPaymentResponse { get; init; } 
    #else
    public PaymentResponse1? RepeatedPaymentResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested Reversal Message Response.
    /// </summary>
    [IsoId("_YOXAO4YMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Reversal Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpeatdRvslRspn")]
    #endif
    [IsoXmlTag("RpeatdRvslRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReversalResponse1? RepeatedReversalResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalResponse1? RepeatedReversalResponse { get; init; } 
    #else
    public ReversalResponse1? RepeatedReversalResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested StoredValue Message Response.
    /// </summary>
    [IsoId("_YOXAPYYMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Stored Value Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpeatdStordValRspn")]
    #endif
    [IsoXmlTag("RpeatdStordValRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StoredValueResponse2? RepeatedStoredValueResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StoredValueResponse2? RepeatedStoredValueResponse { get; init; } 
    #else
    public StoredValueResponse2? RepeatedStoredValueResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested CardAcquisition Message Response.
    /// </summary>
    [IsoId("_YOXAP4YMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Card Acquisition Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpeatdCardAcqstnRspn")]
    #endif
    [IsoXmlTag("RpeatdCardAcqstnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAcquisitionResponse1? RepeatedCardAcquisitionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAcquisitionResponse1? RepeatedCardAcquisitionResponse { get; init; } 
    #else
    public CardAcquisitionResponse1? RepeatedCardAcquisitionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the requested SendApplicationProtocolDataUnitCardReader Message Response.
    /// </summary>
    [IsoId("_YOXAQYYMEemxIqbaFEE8-w")]
    [DisplayName("Repeated Send Application Protocol Data Unit Card Reader Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpeatdSndApplPrtcolDataUnitCardRdrRspn")]
    #endif
    [IsoXmlTag("RpeatdSndApplPrtcolDataUnitCardRdrRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; init; } 
    #else
    public DeviceSendApplicationProtocolDataUnitCardReaderResponse1? RepeatedSendApplicationProtocolDataUnitCardReaderResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
