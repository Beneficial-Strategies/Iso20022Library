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


namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The TradeStatusReport message is exchanged between parties involved in the trade finance domain to report the transaction level status of a transaction previously received. It informs the sender about the positive or negative status of the referenced transaction, such as acceptance or rejection resulting from technical validation performed by the parser and/or front-office applications. It can be used, for example, to acknowledge receipt of a transaction, to report a syntactical error, to report an unrecognised digital signature, to indicate that further processing is pending, and to indicate that a transaction has been technically accepted for processing by the back-office application. Multiple TradeStatusReport messages may be progressively sent in response to the incremental processing of a single transaction.
/// </summary>
[Description(@"The TradeStatusReport message is exchanged between parties involved in the trade finance domain to report the transaction level status of a transaction previously received. It informs the sender about the positive or negative status of the referenced transaction, such as acceptance or rejection resulting from technical validation performed by the parser and/or front-office applications. It can be used, for example, to acknowledge receipt of a transaction, to report a syntactical error, to report an unrecognised digital signature, to indicate that further processing is pending, and to indicate that a transaction has been technically accepted for processing by the back-office application. Multiple TradeStatusReport messages may be progressively sent in response to the incremental processing of a single transaction.")]
[IsoId("_9hy8JXltEeG7BsjMvd1mEw_-944920037")]
[DisplayName("Trade Status Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeStatusReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.018.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TradStsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.018.001.01";
    
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
    /// Constructs a TradeStatusReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeStatusReportV01( TradeStatusReport1 reqTradeStatusAdviceDetails )
    {
        TradeStatusAdviceDetails = reqTradeStatusAdviceDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the trade status report.
    /// </summary>
    [IsoId("_9hy8JnltEeG7BsjMvd1mEw_-979867813")]
    [DisplayName("Trade Status Advice Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradStsAdvcDtls")]
    #endif
    [IsoXmlTag("TradStsAdvcDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeStatusReport1 TradeStatusAdviceDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeStatusReport1 TradeStatusAdviceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeStatusReport1 TradeStatusAdviceDetails { get; init; } 
    #else
    public TradeStatusReport1 TradeStatusAdviceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the report.
    /// </summary>
    [IsoId("_9hy8J3ltEeG7BsjMvd1mEw_-480119583")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since TradeStatusReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TradeStatusReportV01.

