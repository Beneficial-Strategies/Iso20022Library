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
/// This record is an implementation of the colr.019.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// This message is sent by a trading party to its triparty agent to instruct the agent to perform a specific action on a collateral management transaction.
/// It is also sent by an account owner to an account servicer where the account servicer manages the account at the triparty agent on behalf of the trading party. The account owner may be a global custodian which manages an account with a triparty agent on behalf of their client or an investment management institution or a broker/dealer which has an account with their custodian.
/// 
/// Usage:
/// The triparty collateral management service is used by two trading parties at the agreement of a business transaction (for example, a repo, a securities loan, ... ) when they want to secure the transaction with collateral. The management of this collateral (that is, agreeing on quantity and type, marking to market, ... ) is done by a third party, the triparty collateral manager.
/// 
/// Before starting to use these services, the three parties will first sign a contract in which they stipulate the rules of the agreement.
/// </summary>
[Description(@"Scope:|This message is sent by a trading party to its triparty agent to instruct the agent to perform a specific action on a collateral management transaction.|It is also sent by an account owner to an account servicer where the account servicer manages the account at the triparty agent on behalf of the trading party. The account owner may be a global custodian which manages an account with a triparty agent on behalf of their client or an investment management institution or a broker/dealer which has an account with their custodian.||Usage:|The triparty collateral management service is used by two trading parties at the agreement of a business transaction (for example, a repo, a securities loan, ... ) when they want to secure the transaction with collateral. The management of this collateral (that is, agreeing on quantity and type, marking to market, ... ) is done by a third party, the triparty collateral manager.||Before starting to use these services, the three parties will first sign a contract in which they stipulate the rules of the agreement.")]
[IsoId("_2uaNLSs7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Transaction Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TripartyCollateralTransactionInstructionV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.019.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollTxInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.019.001.01";
    
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
    /// Constructs a TripartyCollateralTransactionInstructionV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TripartyCollateralTransactionInstructionV01( TransactionIdentifications45 reqTransactionInstructionIdentification,Pagination1 reqPagination,CollateralParameters10 reqGeneralParameters,CollateralParties10 reqCollateralParties,DealTransactionDetails5 reqDealTransactionDetails,CollateralDate2 reqDealTransactionDate )
    {
        TransactionInstructionIdentification = reqTransactionInstructionIdentification;
        Pagination = reqPagination;
        GeneralParameters = reqGeneralParameters;
        CollateralParties = reqCollateralParties;
        DealTransactionDetails = reqDealTransactionDetails;
        DealTransactionDate = reqDealTransactionDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the instruction or the transaction as known by the instructing  or the receiving party.
    /// </summary>
    [IsoId("_2uaNMSs7EeySlt9bF77XfA")]
    [DisplayName("Transaction Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInstrId")]
    #endif
    [IsoXmlTag("TxInstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifications45 TransactionInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifications45 TransactionInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifications45 TransactionInstructionIdentification { get; init; } 
    #else
    public TransactionIdentifications45 TransactionInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Link to another transaction (or instruction) that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_2uaNMys7EeySlt9bF77XfA")]
    [DisplayName("Linkages")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lnkgs")]
    #endif
    [IsoXmlTag("Lnkgs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Linkages58? Linkages { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Linkages58? Linkages { get; init; } 
    #else
    public Linkages58? Linkages { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaNNSs7EeySlt9bF77XfA")]
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
    /// Specifies the different parameters of the collateral transaction or instruction.
    /// </summary>
    [IsoId("_2uaNNys7EeySlt9bF77XfA")]
    [DisplayName("General Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlParams")]
    #endif
    [IsoXmlTag("GnlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralParameters10 GeneralParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralParameters10 GeneralParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParameters10 GeneralParameters { get; init; } 
    #else
    public CollateralParameters10 GeneralParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_2uaNOSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPties")]
    #endif
    [IsoXmlTag("CollPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralParties10 CollateralParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralParties10 CollateralParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParties10 CollateralParties { get; init; } 
    #else
    public CollateralParties10 CollateralParties { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the information related to the deal.
    /// </summary>
    [IsoId("_2uaNOys7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealTxDtls")]
    #endif
    [IsoXmlTag("DealTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DealTransactionDetails5 DealTransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DealTransactionDetails5 DealTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DealTransactionDetails5 DealTransactionDetails { get; init; } 
    #else
    public DealTransactionDetails5 DealTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the dates related to the triparty collateral instruction or transactions.
    /// </summary>
    [IsoId("_2uaNPSs7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealTxDt")]
    #endif
    [IsoXmlTag("DealTxDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralDate2 DealTransactionDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralDate2 DealTransactionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralDate2 DealTransactionDate { get; init; } 
    #else
    public CollateralDate2 DealTransactionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Securities movements.
    /// </summary>
    [IsoId("_2uaNPys7EeySlt9bF77XfA")]
    [DisplayName("Securities Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmnt")]
    #endif
    [IsoXmlTag("SctiesMvmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesMovement9? SecuritiesMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesMovement9? SecuritiesMovement { get; init; } 
    #else
    public SecuritiesMovement9? SecuritiesMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movements.
    /// </summary>
    [IsoId("_2uaNQSs7EeySlt9bF77XfA")]
    [DisplayName("Cash Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmnt")]
    #endif
    [IsoXmlTag("CshMvmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashMovement8? CashMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashMovement8? CashMovement { get; init; } 
    #else
    public CashMovement8? CashMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_2uaNQys7EeySlt9bF77XfA")]
    [DisplayName("Other Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPties")]
    #endif
    [IsoXmlTag("OthrPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherParties38? OtherParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherParties38? OtherParties { get; init; } 
    #else
    public OtherParties38? OtherParties { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2uaNRSs7EeySlt9bF77XfA")]
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


// Since TripartyCollateralTransactionInstructionV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralTransactionInstructionV01.

