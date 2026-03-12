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


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.037.002.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The  PortfolioTransferNotification is sent by an account servicer to another account servicer to exchange transfer settlement details information during a retail or institutional client portfolio transfer.
/// The account servicer will typically be local agent or global custodian acting on behalf of an investment management institution, a broker/dealer or a retail client.
/// 
/// Usage
/// The exchange of transfer settlement details is the provision, by the delivering account servicer to the receiving account servicer, of the settlement data (such as trade date, settlement date, delivering settlement chain, quantities) of the individual transfers that will take place during a full or partial portfolio transfer. This delivering account servicer message may also include, for validation, the receiving settlement chain as provided by the client. In case the receiving settlement chain is not available to the delivering account servicer, the receiving account servicer may in return provide to the delivering account servicer the receiving settlement chain using the same message.
/// 
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|The  PortfolioTransferNotification is sent by an account servicer to another account servicer to exchange transfer settlement details information during a retail or institutional client portfolio transfer.|The account servicer will typically be local agent or global custodian acting on behalf of an investment management institution, a broker/dealer or a retail client.||Usage|The exchange of transfer settlement details is the provision, by the delivering account servicer to the receiving account servicer, of the settlement data (such as trade date, settlement date, delivering settlement chain, quantities) of the individual transfers that will take place during a full or partial portfolio transfer. This delivering account servicer message may also include, for validation, the receiving settlement chain as provided by the client. In case the receiving settlement chain is not available to the delivering account servicer, the receiving account servicer may in return provide to the delivering account servicer the receiving settlement chain using the same message.||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
[IsoId("_IPiiUwn-Eeqvb4kQR8No8g")]
[DisplayName("Portfolio Transfer Notification 002 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PortfolioTransferNotification002V06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.037.002.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.037.002.06";
    
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
    /// Constructs a PortfolioTransferNotification002V06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PortfolioTransferNotification002V06( Pagination1 reqPagination,Statement68 reqStatementGeneralDetails,SecuritiesAccount30 reqSafekeepingAccount )
    {
        Pagination = reqPagination;
        StatementGeneralDetails = reqStatementGeneralDetails;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_IPiiWgn-Eeqvb4kQR8No8g")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination1 Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination1 Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1 Pagination { get; init; } 
    #else
    public Pagination1 Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Provides general information on the notification.
    /// </summary>
    [IsoId("_IPiiXAn-Eeqvb4kQR8No8g")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement68 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement68 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement68 StatementGeneralDetails { get; init; } 
    #else
    public Statement68 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_IPiiXgn-Eeqvb4kQR8No8g")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification156? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification156? AccountOwner { get; init; } 
    #else
    public PartyIdentification156? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_IPiiYAn-Eeqvb4kQR8No8g")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount30 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount30 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount30 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount30 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the transfer.
    /// </summary>
    [IsoId("_IPiiYgn-Eeqvb4kQR8No8g")]
    [DisplayName("Transfer Notification Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfNtfctnDtls")]
    #endif
    [IsoXmlTag("TrfNtfctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTradeDetails114? TransferNotificationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTradeDetails114? TransferNotificationDetails { get; init; } 
    #else
    public SecuritiesTradeDetails114? TransferNotificationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PortfolioTransferNotification002V06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PortfolioTransferNotification002V06.

