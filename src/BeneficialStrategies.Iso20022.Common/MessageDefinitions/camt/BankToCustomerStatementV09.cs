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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.053.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The BankToCustomerStatement message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It is used to inform the account owner, or authorised party, of the entries booked to the account, and to provide the owner with balance information on the account at a given point in time.
/// Usage
/// The BankToCustomerStatement message can contain reports for more than one account. It provides information for cash management and/or reconciliation.
/// It contains information on booked entries only.
/// It can include underlying details of transactions that have been included in the entry.
/// The message is exchanged as defined between the account servicer and the account owner. It provides information on items that have been booked to the account and also balance information. Depending on services and schedule agreed between banks and their customers, statements may be generated and exchanged accordingly, for example for intraday or prior day periods.
/// It is possible that the receiver of the message is not the account owner, but a party entitled through arrangement with the account owner to receive the account information (also known as recipient).
/// </summary>
[Description(@"Scope|The BankToCustomerStatement message is sent by the account servicer to an account owner or to a party authorised by the account owner to receive the message. It is used to inform the account owner, or authorised party, of the entries booked to the account, and to provide the owner with balance information on the account at a given point in time.|Usage|The BankToCustomerStatement message can contain reports for more than one account. It provides information for cash management and/or reconciliation.|It contains information on booked entries only.|It can include underlying details of transactions that have been included in the entry.|The message is exchanged as defined between the account servicer and the account owner. It provides information on items that have been booked to the account and also balance information. Depending on services and schedule agreed between banks and their customers, statements may be generated and exchanged accordingly, for example for intraday or prior day periods.|It is possible that the receiver of the message is not the account owner, but a party entitled through arrangement with the account owner to receive the account information (also known as recipient).")]
[IsoId("_7wsWs9b-Eeq_l4BJLVUF2Q")]
[DisplayName("Bank To Customer Statement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BankToCustomerStatementV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.053.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "BkToCstmrStmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.053.001.09";
    
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
    /// Constructs a BankToCustomerStatementV09 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BankToCustomerStatementV09( GroupHeader81 reqGroupHeader,AccountStatement10 reqStatement )
    {
        GroupHeader = reqGroupHeader;
        Statement = reqStatement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common information for the message.
    /// </summary>
    [IsoId("_7wsWv9b-Eeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader81 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader81 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader81 GroupHeader { get; init; } 
    #else
    public GroupHeader81 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Reports on booked entries and balances for a cash account.
    /// </summary>
    [IsoId("_7wsWwdb-Eeq_l4BJLVUF2Q")]
    [DisplayName("Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stmt")]
    #endif
    [IsoXmlTag("Stmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountStatement10 Statement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountStatement10 Statement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatement10 Statement { get; init; } 
    #else
    public AccountStatement10 Statement { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7wsWw9b-Eeq_l4BJLVUF2Q")]
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


// Since BankToCustomerStatementV09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to BankToCustomerStatementV09.

