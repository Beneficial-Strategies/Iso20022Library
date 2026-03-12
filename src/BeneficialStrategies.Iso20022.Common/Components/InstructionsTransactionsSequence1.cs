// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides input capability for multiple instructions on elective corporate action events via a single instruction message through using Transaction Sequence Number.
/// </summary>
[IsoId("_gaqnAOceEei5aPS232E3Mw")]
[DisplayName("Instructions Transactions Sequence")]
public partial record InstructionsTransactionsSequence1
{
    #nullable enable
    
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_qqKEYecfEei5aPS232E3Mw")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    
    /// <summary>
    /// Instruction quantity for a given transaction sequence number.
    /// </summary>
    [IsoId("_NA4c8-cgEei5aPS232E3Mw")]
    [DisplayName("Instruction Quantity")]
    [IsoXmlTag("InstrQty")]
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    
    /// <summary>
    /// For rights subscription events with an oversubscription feature, the quantity of the oversubscription for the given instruction.
    /// </summary>
    [IsoId("_NA4c8ucgEei5aPS232E3Mw")]
    [DisplayName("Oversubscription Quantity")]
    [IsoXmlTag("OvrsbcptQty")]
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; init; } 
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_k_fLIecgEei5aPS232E3Mw")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    
    
    #nullable disable
    
}
