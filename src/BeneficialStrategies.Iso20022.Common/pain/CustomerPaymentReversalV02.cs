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


namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.
/// The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.
/// The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[Description(@"Scope|The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.|Usage|The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.|The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.|The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.")]
[IsoId("_GXLbgtEvEd-BzquC8wXy7w_66905835")]
[DisplayName("Customer Payment Reversal V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerPaymentReversalV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pain.007.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CstmrPmtRvsl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.007.001.02";
    
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
    /// Constructs a CustomerPaymentReversalV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerPaymentReversalV02( GroupHeader40 reqGroupHeader,OriginalGroupInformation22 reqOriginalGroupInformation )
    {
        GroupHeader = reqGroupHeader;
        OriginalGroupInformation = reqOriginalGroupInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_GXUlYNEvEd-BzquC8wXy7w_67825938")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader40 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader40 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader40 GroupHeader { get; init; } 
    #else
    public GroupHeader40 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_GXUlYdEvEd-BzquC8wXy7w_67826083")]
    [DisplayName("Original Group Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInf")]
    #endif
    [IsoXmlTag("OrgnlGrpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalGroupInformation22 OriginalGroupInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalGroupInformation22 OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation22 OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupInformation22 OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original payment information, to which the reversal message refers.
    /// </summary>
    [IsoId("_GXUlYtEvEd-BzquC8wXy7w_-1091943635")]
    [DisplayName("Original Payment Information And Reversal")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlPmtInfAndRvsl")]
    #endif
    [IsoXmlTag("OrgnlPmtInfAndRvsl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInformation2? OriginalPaymentInformationAndReversal { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInformation2? OriginalPaymentInformationAndReversal { get; init; } 
    #else
    public OriginalPaymentInformation2? OriginalPaymentInformationAndReversal { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CustomerPaymentReversalV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CustomerPaymentReversalV02.

