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
    
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_7gWa81nNEeSPgY23yCMQSQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_7gWa9VnNEeSPgY23yCMQSQ")]
    [DisplayName("Agreement")]
    [IsoXmlTag("Agrmt")]
    public Agreement2? Agreement { get; init; } 
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_8jVMoGNqEeSIWbZ6by9dnA")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation3 Obligation { get; init; } 
    
    /// <summary>
    /// Provides general information on the report such as the statement identification.
    /// </summary>
    [IsoId("_7gWa_1nNEeSPgY23yCMQSQ")]
    [DisplayName("Statement Parameters")]
    [IsoXmlTag("StmtParams")]
    public required Statement32 StatementParameters { get; init; } 
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_7gWbAVnNEeSPgY23yCMQSQ")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination? Pagination { get; init; } 
    
    /// <summary>
    /// Provides details on the interest statement.
    /// </summary>
    [IsoId("_7gWbA1nNEeSPgY23yCMQSQ")]
    [DisplayName("Interest Statement")]
    [IsoXmlTag("IntrstStmt")]
    public required InterestStatement3 InterestStatement { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_7gWbBVnNEeSPgY23yCMQSQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since InterestPaymentStatementV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InterestPaymentStatementV03.

