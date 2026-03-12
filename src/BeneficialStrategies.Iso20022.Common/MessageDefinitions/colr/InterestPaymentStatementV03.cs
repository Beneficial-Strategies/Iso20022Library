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


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.015.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by either the collateral giver or its collateral manager to the collateral taker or its collateral manager. It is used to report the interest amounts calculated based on the effective posted collateral amount, over a specific period of time agreed by both parties.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The InterestPaymentStatement message is used for reporting the interest per period on collateral held.
/// </summary>
[Description(@"Scope|This message is sent by either the collateral giver or its collateral manager to the collateral taker or its collateral manager. It is used to report the interest amounts calculated based on the effective posted collateral amount, over a specific period of time agreed by both parties.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The InterestPaymentStatement message is used for reporting the interest per period on collateral held.")]
[IsoId("_7gWa8VnNEeSPgY23yCMQSQ")]
[DisplayName("Interest Payment Statement V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InterestPaymentStatementV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.015.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntrstPmtStmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.015.001.03";
    
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
    /// Constructs a InterestPaymentStatementV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InterestPaymentStatementV03( System.String reqTransactionIdentification,Obligation3 reqObligation,Statement32 reqStatementParameters,InterestStatement3 reqInterestStatement )
    {
        TransactionIdentification = reqTransactionIdentification;
        Obligation = reqObligation;
        StatementParameters = reqStatementParameters;
        InterestStatement = reqInterestStatement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_7gWa81nNEeSPgY23yCMQSQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_7gWa9VnNEeSPgY23yCMQSQ")]
    [DisplayName("Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agrmt")]
    #endif
    [IsoXmlTag("Agrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Agreement2? Agreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement2? Agreement { get; init; } 
    #else
    public Agreement2? Agreement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_8jVMoGNqEeSIWbZ6by9dnA")]
    [DisplayName("Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgtn")]
    #endif
    [IsoXmlTag("Oblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation3 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Obligation3 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation3 Obligation { get; init; } 
    #else
    public Obligation3 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides general information on the report such as the statement identification.
    /// </summary>
    [IsoId("_7gWa_1nNEeSPgY23yCMQSQ")]
    [DisplayName("Statement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtParams")]
    #endif
    [IsoXmlTag("StmtParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement32 StatementParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement32 StatementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement32 StatementParameters { get; init; } 
    #else
    public Statement32 StatementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_7gWbAVnNEeSPgY23yCMQSQ")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? Pagination { get; init; } 
    #else
    public Pagination? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the interest statement.
    /// </summary>
    [IsoId("_7gWbA1nNEeSPgY23yCMQSQ")]
    [DisplayName("Interest Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstStmt")]
    #endif
    [IsoXmlTag("IntrstStmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InterestStatement3 InterestStatement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InterestStatement3 InterestStatement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestStatement3 InterestStatement { get; init; } 
    #else
    public InterestStatement3 InterestStatement { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_7gWbBVnNEeSPgY23yCMQSQ")]
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


// Since InterestPaymentStatementV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InterestPaymentStatementV03.

