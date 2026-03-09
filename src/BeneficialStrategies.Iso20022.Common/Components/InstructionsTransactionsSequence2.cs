// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides input capability for multiple instructions on elective corporate action events via a single instruction message through using Transaction Sequence Number.
/// </summary>
[IsoId("_ocESMzDtEey2N-DB7H7A5A")]
[DisplayName("Instructions Transactions Sequence")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructionsTransactionsSequence2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_oxhksTDtEey2N-DB7H7A5A")]
    [DisplayName("Transaction Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeqNb")]
    #endif
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionSequenceNumber { get; init; } 
    #else
    public System.String? TransactionSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Instruction quantity for a given transaction sequence number.
    /// </summary>
    [IsoId("_oxhkszDtEey2N-DB7H7A5A")]
    [DisplayName("Instruction Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrQty")]
    #endif
    [IsoXmlTag("InstrQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// For rights subscription events with an oversubscription feature, the quantity of the oversubscription for the given instruction.
    /// </summary>
    [IsoId("_oxhktTDtEey2N-DB7H7A5A")]
    [DisplayName("Oversubscription Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptQty")]
    #endif
    [IsoXmlTag("OvrsbcptQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity31Choice_? OversubscriptionQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity31Choice_? OversubscriptionQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity31Choice_? OversubscriptionQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_oxhktzDtEey2N-DB7H7A5A")]
    [DisplayName("Customer Reference Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrRefId")]
    #endif
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax30Text? CustomerReferenceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CustomerReferenceIdentification { get; init; } 
    #else
    public System.String? CustomerReferenceIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
