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
    
    #nullable enable
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_2uaNEys7EeySlt9bF77XfA")]
    [DisplayName("Transaction Instruction Identification")]
    [IsoXmlTag("TxInstrId")]
    public required TransactionIdentifications46 TransactionInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Reference to the unambiguous identification of the cancellation request as per the account owner.
    /// </summary>
    [IsoId("_2uaNFSs7EeySlt9bF77XfA")]
    [DisplayName("Cancellation Request Reference")]
    [IsoXmlTag("CxlReqRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CancellationRequestReference { get; init; } 
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaNFys7EeySlt9bF77XfA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; } 
    
    /// <summary>
    /// Provides the status of an instruction.
    /// </summary>
    [IsoId("_2uaNGSs7EeySlt9bF77XfA")]
    [DisplayName("Instruction Processing Status")]
    [IsoXmlTag("InstrPrcgSts")]
    public ProcessingStatus82Choice_? InstructionProcessingStatus { get; init; } 
    
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_2uaNGys7EeySlt9bF77XfA")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus33Choice_? MatchingStatus { get; init; } 
    
    /// <summary>
    /// Provides the status of a cancellation request or status query.
    /// </summary>
    [IsoId("_2uaNHSs7EeySlt9bF77XfA")]
    [DisplayName("Cancellation Processing Status")]
    [IsoXmlTag("CxlPrcgSts")]
    public CancellationStatus30Choice_? CancellationProcessingStatus { get; init; } 
    
    /// <summary>
    /// provides general information about the instruction and collateral transaction the message refers to.
    /// </summary>
    [IsoId("_2uaNHys7EeySlt9bF77XfA")]
    [DisplayName("General Parameters")]
    [IsoXmlTag("GnlParams")]
    public required CollateralParameters12 GeneralParameters { get; init; } 
    
    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_2uaNISs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    [IsoXmlTag("CollPties")]
    public required CollateralParties8 CollateralParties { get; init; } 
    
    /// <summary>
    /// Specifies the information related to the deal.
    /// </summary>
    [IsoId("_2uaNIys7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Details")]
    [IsoXmlTag("DealTxDtls")]
    public required DealTransactionDetails7 DealTransactionDetails { get; init; } 
    
    /// <summary>
    /// Identifies the dates related to the triparty collateral instruction or transactions.
    /// </summary>
    [IsoId("_2uaNJSs7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Date")]
    [IsoXmlTag("DealTxDt")]
    public required CollateralDate2 DealTransactionDate { get; init; } 
    
    /// <summary>
    /// Securities movements.
    /// </summary>
    [IsoId("_2uaNJys7EeySlt9bF77XfA")]
    [DisplayName("Securities Movement")]
    [IsoXmlTag("SctiesMvmnt")]
    public SecuritiesMovement8? SecuritiesMovement { get; init; } 
    
    /// <summary>
    ///  Cash movement
    /// </summary>
    [IsoId("_2uaNKSs7EeySlt9bF77XfA")]
    [DisplayName("Cash Movement")]
    [IsoXmlTag("CshMvmnt")]
    public CashMovement7? CashMovement { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2uaNKys7EeySlt9bF77XfA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since TripartyCollateralTransactionInstructionProcessingStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralTransactionInstructionProcessingStatusAdviceV01.

