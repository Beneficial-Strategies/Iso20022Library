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


namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.008.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BuyInResponse message is sent by the clearing member to the central counterparty as a response to the previous buy-in notification message.
/// 
/// The message definition is intended for use with the ISO 20022 Business Application Header.
/// 
/// Usage
/// The BuyInResponse may be sent in response to the BuyInNotification message. However, the use of this message in the buy in process is optional and depends on the rules set by each central counterparty.
/// </summary>
[Description(@"Scope|The BuyInResponse message is sent by the clearing member to the central counterparty as a response to the previous buy-in notification message.||The message definition is intended for use with the ISO 20022 Business Application Header.||Usage|The BuyInResponse may be sent in response to the BuyInNotification message. However, the use of this message in the buy in process is optional and depends on the rules set by each central counterparty.")]
[IsoId("_2_0twS0lEeSRe9rElPHBfg")]
[DisplayName("Buy In Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BuyInResponseV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.008.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BuyInRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.008.001.03";
    
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
    /// Constructs a BuyInResponseV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BuyInResponseV03( BuyIn3 reqBuyInResponseDetails )
    {
        BuyInResponseDetails = reqBuyInResponseDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the instructing party.
    /// </summary>
    [IsoId("_2_0twy0lEeSRe9rElPHBfg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionIdentification { get; init; } 
    #else
    public System.String? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides response details such as a request for delay and the number of days associated to that request.
    /// </summary>
    [IsoId("_2_0txS0lEeSRe9rElPHBfg")]
    [DisplayName("Buy In Response Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyInRspnDtls")]
    #endif
    [IsoXmlTag("BuyInRspnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BuyIn3 BuyInResponseDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BuyIn3 BuyInResponseDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BuyIn3 BuyInResponseDetails { get; init; } 
    #else
    public BuyIn3 BuyInResponseDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the original settlement obligation that did not settle and for which the buy in process will be launched.
    /// </summary>
    [IsoId("_2_0txy0lEeSRe9rElPHBfg")]
    [DisplayName("Original Settlement Obligation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlSttlmOblgtnDtls")]
    #endif
    [IsoXmlTag("OrgnlSttlmOblgtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementObligation7? OriginalSettlementObligationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementObligation7? OriginalSettlementObligationDetails { get; init; } 
    #else
    public SettlementObligation7? OriginalSettlementObligationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2_0tyS0lEeSRe9rElPHBfg")]
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


// Since BuyInResponseV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BuyInResponseV03.

