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
/// This record is an implementation of the colr.021.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// This message is sent by a triparty agent after the receipt of a collateral transaction or instruction from the collateral giver or taker to advise  that a counterparty has alleged an instruction or a transaction against the account owner&apos;s account at the TPA and that the TPA could not find the corresponding transaction or instruction of the account owner.
/// The allegement is used for initiation, modification and termination.
/// 
/// In this message, the Sender is the triparty agent and the Receiver is either the collateral taker or the collateral giver or their account servicer.
/// 
/// Usage:
/// An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner&apos;s account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// </summary>
[Description(@"Scope:|This message is sent by a triparty agent after the receipt of a collateral transaction or instruction from the collateral giver or taker to advise  that a counterparty has alleged an instruction or a transaction against the account owner's account at the TPA and that the TPA could not find the corresponding transaction or instruction of the account owner.|The allegement is used for initiation, modification and termination.||In this message, the Sender is the triparty agent and the Receiver is either the collateral taker or the collateral giver or their account servicer.||Usage:|An account servicer sends a SecuritiesSettlementTransactionAllegementNotification to an account owner to advise the account owner that a counterparty has alleged an instruction against the account owner's account at the account servicer and that the account servicer could not find the corresponding instruction of the account owner.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.")]
[IsoId("_xMpNYSs7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Allegement Notification V")]
public partial record TripartyCollateralAllegementNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.021.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollAllgmtNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.021.001.01";
    
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
    [IsoId("_xMpNYys7EeySlt9bF77XfA")]
    [DisplayName("Transaction Instruction Identification")]
    [IsoXmlTag("TxInstrId")]
    public required TransactionIdentifications44 TransactionInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_xMpNZSs7EeySlt9bF77XfA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; } 
    
    /// <summary>
    /// Specifies the different parameters of the collateral instruction or transaction.
    /// </summary>
    [IsoId("_xMpNZys7EeySlt9bF77XfA")]
    [DisplayName("General Parameters")]
    [IsoXmlTag("GnlParams")]
    public required CollateralParameters11 GeneralParameters { get; init; } 
    
    /// <summary>
    /// Identifies the chain of collateral parties. Party A and B will be the opposite  from that provided in the unmatched instruction.
    /// </summary>
    [IsoId("_xMpNaSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    [IsoXmlTag("CollPties")]
    public required CollateralParties8 CollateralParties { get; init; } 
    
    /// <summary>
    /// Specifies the information related to the deal.
    /// </summary>
    [IsoId("_xMpNays7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Details")]
    [IsoXmlTag("DealTxDtls")]
    public required DealTransactionDetails6 DealTransactionDetails { get; init; } 
    
    /// <summary>
    /// Identifies the dates related to the triparty collateral instruction or transactions.
    /// </summary>
    [IsoId("_xMpNbSs7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Date")]
    [IsoXmlTag("DealTxDt")]
    public required CollateralDate2 DealTransactionDate { get; init; } 
    
    /// <summary>
    /// Securities movements.
    /// </summary>
    [IsoId("_xMpNbys7EeySlt9bF77XfA")]
    [DisplayName("Securities Movement")]
    [IsoXmlTag("SctiesMvmnt")]
    public SecuritiesMovement7? SecuritiesMovement { get; init; } 
    
    /// <summary>
    /// Cash movements.
    /// </summary>
    [IsoId("_xMpNcSs7EeySlt9bF77XfA")]
    [DisplayName("Cash Movement")]
    [IsoXmlTag("CshMvmnt")]
    public CashMovement5? CashMovement { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_xMpNcys7EeySlt9bF77XfA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since TripartyCollateralAllegementNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralAllegementNotificationV01.

