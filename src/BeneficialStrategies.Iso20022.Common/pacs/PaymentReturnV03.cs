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


namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PaymentReturn message is sent by an agent to the previous agent in the payment chain to undo a payment previously settled.
/// Usage
/// The PaymentReturn message is exchanged between agents to return funds after settlement of credit transfer instructions (i.e. FIToFICustomerCreditTransfer message and FinancialInstitutionCreditTransfer message) or direct debit instructions (FIToFICustomerDirectDebit message).
/// The PaymentReturn message should not be used between agents and non-financial institution customers. Non-financial institution customers will be informed about a debit or a credit on their account(s) through a BankToCustomerDebitCreditNotification message (&apos;notification&apos;) and/or BankToCustomerAccountReport/BankToCustomerStatement message (&apos;statement&apos;).
/// The PaymentReturn message can be used to return single instructions or multiple instructions from one or different files.
/// The PaymentReturn message can be used in domestic and cross-border scenarios.
/// The PaymentReturn message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// </summary>
[Description(@"Scope|The PaymentReturn message is sent by an agent to the previous agent in the payment chain to undo a payment previously settled.|Usage|The PaymentReturn message is exchanged between agents to return funds after settlement of credit transfer instructions (i.e. FIToFICustomerCreditTransfer message and FinancialInstitutionCreditTransfer message) or direct debit instructions (FIToFICustomerDirectDebit message).|The PaymentReturn message should not be used between agents and non-financial institution customers. Non-financial institution customers will be informed about a debit or a credit on their account(s) through a BankToCustomerDebitCreditNotification message ('notification') and/or BankToCustomerAccountReport/BankToCustomerStatement message ('statement').|The PaymentReturn message can be used to return single instructions or multiple instructions from one or different files.|The PaymentReturn message can be used in domestic and cross-border scenarios.|The PaymentReturn message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.")]
[IsoId("_sKU3QVkyEeGeoaLUQk__nA_-1417444477")]
[DisplayName("Payment Return V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentReturnV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "pacs.004.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtRtr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pacs.004.001.03";
    
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
    /// Constructs a PaymentReturnV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentReturnV03( GroupHeader54 reqGroupHeader )
    {
        GroupHeader = reqGroupHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_sKeoQFkyEeGeoaLUQk__nA_1786953007")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader54 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader54 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader54 GroupHeader { get; init; } 
    #else
    public GroupHeader54 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_sKeoQVkyEeGeoaLUQk__nA_903719720")]
    [DisplayName("Original Group Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlGrpInf")]
    #endif
    [IsoXmlTag("OrgnlGrpInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupHeader2? OriginalGroupInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupHeader2? OriginalGroupInformation { get; init; } 
    #else
    public OriginalGroupHeader2? OriginalGroupInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the original transactions, to which the return message refers.
    /// </summary>
    [IsoId("_sKeoQlkyEeGeoaLUQk__nA_-93352633")]
    [DisplayName("Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInf")]
    #endif
    [IsoXmlTag("TxInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction34? TransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction34? TransactionInformation { get; init; } 
    #else
    public PaymentTransaction34? TransactionInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_sKnyMFkyEeGeoaLUQk__nA_-789030620")]
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


// Since PaymentReturnV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PaymentReturnV03.

