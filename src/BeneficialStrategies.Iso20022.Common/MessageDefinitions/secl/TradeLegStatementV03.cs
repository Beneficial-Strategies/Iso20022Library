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



namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TradeLegStatement message is sent by the central counterparty (CCP) to a clearing member to report all trades that have been executed by the trading platform.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The TradeLegStatement message may be either sent:
/// - during the day (to report trades execution by batch) or
/// - as an end of day report.
/// </summary>
[Description(@"Scope|The TradeLegStatement message is sent by the central counterparty (CCP) to a clearing member to report all trades that have been executed by the trading platform.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The TradeLegStatement message may be either sent:|- during the day (to report trades execution by batch) or|- as an end of day report.")]
[IsoId("_DlZHIS0mEeSRe9rElPHBfg")]
[DisplayName("Trade Leg Statement V")]
public partial record TradeLegStatementV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TradLegStmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.003.001.03";
    
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
    /// Provides various statement parameters such as the statement identification, the statement date and time or the statement frequency.
    /// </summary>
    [IsoId("_DlZuMS0mEeSRe9rElPHBfg")]
    [DisplayName("Statement Parameters")]
    [IsoXmlTag("StmtParams")]
    public required Statement31 StatementParameters { get; init; } 
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_DlZuMy0mEeSRe9rElPHBfg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination Pagination { get; init; } 
    
    /// <summary>
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_DlZuNS0mEeSRe9rElPHBfg")]
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    
    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_DlZuNy0mEeSRe9rElPHBfg")]
    [DisplayName("Clearing Account")]
    [IsoXmlTag("ClrAcct")]
    public SecuritiesAccount18? ClearingAccount { get; init; } 
    
    /// <summary>
    /// Provides the statement details.
    /// </summary>
    [IsoId("_DlZuOS0mEeSRe9rElPHBfg")]
    [DisplayName("Statement Details")]
    [IsoXmlTag("StmtDtls")]
    public required TradeLegStatement3 StatementDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_DlZuOy0mEeSRe9rElPHBfg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since TradeLegStatementV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TradeLegStatementV03.

