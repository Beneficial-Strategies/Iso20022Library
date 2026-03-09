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
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
[IsoId("_tOlJk1kyEeGeoaLUQk__nA_-1596735484")]
[DisplayName("Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransaction37
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the assigner, to unambiguously identify a cancellation request.||Usage: The cancellation request identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    [IsoId("_tOlJlFkyEeGeoaLUQk__nA_-1710574550")]
    [DisplayName("Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlId")]
    #endif
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationIdentification { get; init; } 
    #else
    public System.String? CancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements to uniquely and unambiguously identify an exception or an investigation workflow.
    /// </summary>
    [IsoId("_tOuTgFkyEeGeoaLUQk__nA_1587320393")]
    [DisplayName("Case")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Case")]
    #endif
    [IsoXmlTag("Case")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Case3? Case { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Case3? Case { get; init; } 
    #else
    public Case3? Case { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_tOuTgVkyEeGeoaLUQk__nA_590248040")]
    [DisplayName("Original Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstrId")]
    #endif
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalInstructionIdentification { get; init; } 
    #else
    public System.String? OriginalInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    [IsoId("_tOuTglkyEeGeoaLUQk__nA_-329785612")]
    [DisplayName("Original End To End Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlEndToEndId")]
    #endif
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalEndToEndIdentification { get; init; } 
    #else
    public System.String? OriginalEndToEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    [IsoId("_tOuTg1kyEeGeoaLUQk__nA_1356204290")]
    [DisplayName("Original Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstdAmt")]
    #endif
    [IsoXmlTag("OrgnlInstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? OriginalInstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the initiating party originally requested the clearing agent to process the payment.
    /// </summary>
    [IsoId("_tOuThFkyEeGeoaLUQk__nA_359131937")]
    [DisplayName("Original Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlReqdExctnDt")]
    #endif
    [IsoXmlTag("OrgnlReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OriginalRequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OriginalRequestedExecutionDate { get; init; } 
    #else
    public System.DateOnly? OriginalRequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the creditor originally requested the collection of the amount of money from the debtor.
    /// </summary>
    [IsoId("_tO4EgFkyEeGeoaLUQk__nA_-637940416")]
    [DisplayName("Original Requested Collection Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlReqdColltnDt")]
    #endif
    [IsoXmlTag("OrgnlReqdColltnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OriginalRequestedCollectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OriginalRequestedCollectionDate { get; init; } 
    #else
    public System.DateOnly? OriginalRequestedCollectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_tO4EgVkyEeGeoaLUQk__nA_-1635012769")]
    [DisplayName("Cancellation Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsnInf")]
    #endif
    [IsoXmlTag("CxlRsnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCancellationReason2? CancellationReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCancellationReason2? CancellationReasonInformation { get; init; } 
    #else
    public PaymentCancellationReason2? CancellationReasonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    [IsoId("_tO4EglkyEeGeoaLUQk__nA_1662882174")]
    [DisplayName("Original Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlTxRef")]
    #endif
    [IsoXmlTag("OrgnlTxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; } 
    #else
    public OriginalTransactionReference16? OriginalTransactionReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
