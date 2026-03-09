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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeLegStatementV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeLegStatementV03( Statement31 reqStatementParameters,Pagination reqPagination,PartyIdentification35Choice_ reqClearingMember,TradeLegStatement3 reqStatementDetails )
    {
        StatementParameters = reqStatementParameters;
        Pagination = reqPagination;
        ClearingMember = reqClearingMember;
        StatementDetails = reqStatementDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides various statement parameters such as the statement identification, the statement date and time or the statement frequency.
    /// </summary>
    [IsoId("_DlZuMS0mEeSRe9rElPHBfg")]
    [DisplayName("Statement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtParams")]
    #endif
    [IsoXmlTag("StmtParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement31 StatementParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement31 StatementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement31 StatementParameters { get; init; } 
    #else
    public Statement31 StatementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_DlZuMy0mEeSRe9rElPHBfg")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination Pagination { get; init; } 
    #else
    public Pagination Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification of the account owner, that is the clearing member (individual clearing member or general clearing member).
    /// </summary>
    [IsoId("_DlZuNS0mEeSRe9rElPHBfg")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification35Choice_ ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_ ClearingMember { get; init; } 
    #else
    public PartyIdentification35Choice_ ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_DlZuNy0mEeSRe9rElPHBfg")]
    [DisplayName("Clearing Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcct")]
    #endif
    [IsoXmlTag("ClrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount18? ClearingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount18? ClearingAccount { get; init; } 
    #else
    public SecuritiesAccount18? ClearingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the statement details.
    /// </summary>
    [IsoId("_DlZuOS0mEeSRe9rElPHBfg")]
    [DisplayName("Statement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtls")]
    #endif
    [IsoXmlTag("StmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeLegStatement3 StatementDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeLegStatement3 StatementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeLegStatement3 StatementDetails { get; init; } 
    #else
    public TradeLegStatement3 StatementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_DlZuOy0mEeSRe9rElPHBfg")]
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


// Since TradeLegStatementV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TradeLegStatementV03.

