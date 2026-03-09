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


namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// This record is an implementation of the supl.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Supplementary data for payment message definitions.
/// </summary>
[Description(@"Supplementary data for payment message definitions.")]
[IsoId("_ZAIu0PwLEeGHDMP28rpT3g_-1117810318")]
[DisplayName("Payment SD 1 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentSD1V01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "supl.017.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtSD1";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.017.001.01";
    
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
    /// Constructs a PaymentSD1V01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentSD1V01( TransactionData1 reqCardRemittanceInformation )
    {
        CardRemittanceInformation = reqCardRemittanceInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Structured card remittance information supplied in a payment.
    /// </summary>
    [IsoId("_ZAIu0fwLEeGHDMP28rpT3g_-1719162242")]
    [DisplayName("Card Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardRmtInf")]
    #endif
    [IsoXmlTag("CardRmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionData1 CardRemittanceInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionData1 CardRemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionData1 CardRemittanceInformation { get; init; } 
    #else
    public TransactionData1 CardRemittanceInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PaymentSD1V01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PaymentSD1V01.

