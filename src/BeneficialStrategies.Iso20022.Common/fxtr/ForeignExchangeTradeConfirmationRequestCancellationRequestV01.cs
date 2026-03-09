// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.036.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeConfirmationRequestCancellationRequest message is sent from a market participant to a Central matching utility (CMU) to amend the ForeignExchangeTradeConfirmationRequest previously sent.
/// 
/// Usage
/// The request is sent by the market participants to the CMU after the confirmation is requested.
/// </summary>
[Description(@"Scope|The ForeignExchangeTradeConfirmationRequestCancellationRequest message is sent from a market participant to a Central matching utility (CMU) to amend the ForeignExchangeTradeConfirmationRequest previously sent.||Usage|The request is sent by the market participants to the CMU after the confirmation is requested.")]
[IsoId("_NXUBUoHiEeSY3ulMDfpmvA")]
[DisplayName("Foreign Exchange Trade Confirmation Request Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeConfirmationRequestCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.036.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfReqCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeTradeConfirmationRequestCancellationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeConfirmationRequestCancellationRequestV01( Header23 reqHeader,TradePartyIdentification7 reqTradingSideIdentification,TradePartyIdentification7 reqCounterpartyRoleIdentification,System.String reqTradeIdentification,UnderlyingProductIdentifier1Code reqUnderlyingProductType )
    {
        Header = reqHeader;
        TradingSideIdentification = reqTradingSideIdentification;
        CounterpartyRoleIdentification = reqCounterpartyRoleIdentification;
        TradeIdentification = reqTradeIdentification;
        UnderlyingProductType = reqUnderlyingProductType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Message management information.
    /// </summary>
    [IsoId("_vw3rcIHiEeSY3ulMDfpmvA")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header23 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header23 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header23 Header { get; init; } 
    #else
    public Header23 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the cancellation request messge.
    /// </summary>
    [IsoId("_wBWXcIHiEeSY3ulMDfpmvA")]
    [DisplayName("Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlReqId")]
    #endif
    [IsoXmlTag("CxlReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification1? CancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1? CancellationRequestIdentification { get; init; } 
    #else
    public MessageIdentification1? CancellationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the trading side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_wPAY8IHiEeSY3ulMDfpmvA")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification7 TradingSideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification7 TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification7 TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification7 TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the counterparty side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_wezIcIHiEeSY3ulMDfpmvA")]
    [DisplayName("Counterparty Role Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRoleId")]
    #endif
    [IsoXmlTag("CtrPtyRoleId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification7 CounterpartyRoleIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification7 CounterpartyRoleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification7 CounterpartyRoleIdentification { get; init; } 
    #else
    public TradePartyIdentification7 CounterpartyRoleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the trade that needs to be cancelled.
    /// </summary>
    [IsoId("_wvgd8IHiEeSY3ulMDfpmvA")]
    [DisplayName("Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradId")]
    #endif
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TradeIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeIdentification { get; init; } 
    #else
    public System.String TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_w_JccIHiEeSY3ulMDfpmvA")]
    [DisplayName("Underlying Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygPdctTp")]
    #endif
    [IsoXmlTag("UndrlygPdctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnderlyingProductIdentifier1Code UnderlyingProductType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnderlyingProductIdentifier1Code UnderlyingProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingProductIdentifier1Code UnderlyingProductType { get; init; } 
    #else
    public UnderlyingProductIdentifier1Code UnderlyingProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_m-4V8KHiEeS69KkQis5bYg")]
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


// Since ForeignExchangeTradeConfirmationRequestCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationRequestCancellationRequestV01.

