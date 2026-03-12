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
/// This record is an implementation of the colr.020.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope: 
/// This message is sent by a triparty agent after the receipt of a collateral instruction from its client.
/// 
/// In this message, the Sender is the triparty agent and the Receiver is either the collateral taker or the collateral giver or their account servicer.
/// 
/// Usage:
/// This message provides the status of the Triparty collateral transaction or instruction.
/// </summary>
[Description(@"Scope: |This message is sent by a triparty agent after the receipt of a collateral instruction from its client.||In this message, the Sender is the triparty agent and the Receiver is either the collateral taker or the collateral giver or their account servicer.||Usage:|This message provides the status of the Triparty collateral transaction or instruction.")]
[IsoId("_2uaNCys7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Transaction Instruction Processing Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TripartyCollateralTransactionInstructionProcessingStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.020.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollTxInstrPrcgStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.020.001.01";
    
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
    /// Constructs a TripartyCollateralTransactionInstructionProcessingStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TripartyCollateralTransactionInstructionProcessingStatusAdviceV01( TransactionIdentifications46 reqTransactionInstructionIdentification,Pagination1 reqPagination,CollateralParameters12 reqGeneralParameters,CollateralParties8 reqCollateralParties,DealTransactionDetails7 reqDealTransactionDetails,CollateralDate2 reqDealTransactionDate )
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
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_2uaNEys7EeySlt9bF77XfA")]
    [DisplayName("Transaction Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInstrId")]
    #endif
    [IsoXmlTag("TxInstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifications46 TransactionInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifications46 TransactionInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifications46 TransactionInstructionIdentification { get; init; } 
    #else
    public TransactionIdentifications46 TransactionInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to the unambiguous identification of the cancellation request as per the account owner.
    /// </summary>
    [IsoId("_2uaNFSs7EeySlt9bF77XfA")]
    [DisplayName("Cancellation Request Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlReqRef")]
    #endif
    [IsoXmlTag("CxlReqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationRequestReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationRequestReference { get; init; } 
    #else
    public System.String? CancellationRequestReference { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaNFys7EeySlt9bF77XfA")]
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
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_2uaNGSs7EeySlt9bF77XfA")]
    [DisplayName("Instruction Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrPrcgSts")]
    #endif
    [IsoXmlTag("InstrPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingStatus82Choice_? InstructionProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingStatus82Choice_? InstructionProcessingStatus { get; init; } 
    #else
    public ProcessingStatus82Choice_? InstructionProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_2uaNGys7EeySlt9bF77XfA")]
    [DisplayName("Matching Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchgSts")]
    #endif
    [IsoXmlTag("MtchgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus33Choice_? MatchingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus33Choice_? MatchingStatus { get; init; } 
    #else
    public MatchingStatus33Choice_? MatchingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of a cancellation request or status query.
    /// </summary>
    [IsoId("_2uaNHSs7EeySlt9bF77XfA")]
    [DisplayName("Cancellation Processing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlPrcgSts")]
    #endif
    [IsoXmlTag("CxlPrcgSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CancellationStatus30Choice_? CancellationProcessingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationStatus30Choice_? CancellationProcessingStatus { get; init; } 
    #else
    public CancellationStatus30Choice_? CancellationProcessingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// provides general information about the instruction and collateral transaction the message refers to.
    /// </summary>
    [IsoId("_2uaNHys7EeySlt9bF77XfA")]
    [DisplayName("General Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlParams")]
    #endif
    [IsoXmlTag("GnlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralParameters12 GeneralParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralParameters12 GeneralParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParameters12 GeneralParameters { get; init; } 
    #else
    public CollateralParameters12 GeneralParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_2uaNISs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPties")]
    #endif
    [IsoXmlTag("CollPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralParties8 CollateralParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralParties8 CollateralParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParties8 CollateralParties { get; init; } 
    #else
    public CollateralParties8 CollateralParties { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the information related to the deal.
    /// </summary>
    [IsoId("_2uaNIys7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealTxDtls")]
    #endif
    [IsoXmlTag("DealTxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DealTransactionDetails7 DealTransactionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DealTransactionDetails7 DealTransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DealTransactionDetails7 DealTransactionDetails { get; init; } 
    #else
    public DealTransactionDetails7 DealTransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the dates related to the triparty collateral instruction or transactions.
    /// </summary>
    [IsoId("_2uaNJSs7EeySlt9bF77XfA")]
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
    [IsoId("_2uaNJys7EeySlt9bF77XfA")]
    [DisplayName("Securities Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmnt")]
    #endif
    [IsoXmlTag("SctiesMvmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesMovement8? SecuritiesMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesMovement8? SecuritiesMovement { get; init; } 
    #else
    public SecuritiesMovement8? SecuritiesMovement { get; set; } 
    #endif
    
    /// <summary>
    ///  Cash movement
    /// </summary>
    [IsoId("_2uaNKSs7EeySlt9bF77XfA")]
    [DisplayName("Cash Movement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMvmnt")]
    #endif
    [IsoXmlTag("CshMvmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashMovement7? CashMovement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashMovement7? CashMovement { get; init; } 
    #else
    public CashMovement7? CashMovement { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2uaNKys7EeySlt9bF77XfA")]
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


// Since TripartyCollateralTransactionInstructionProcessingStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralTransactionInstructionProcessingStatusAdviceV01.

