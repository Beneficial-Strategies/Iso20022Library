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
/// Information about the reconciliation request.
/// </summary>
[IsoId("_hM43sYtxEeSLQutgI1Ulfw")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction11( TransactionIdentifier1 reqTransactionIdentification,System.String reqReconciliationIdentification )
    {
        TransactionIdentification = reqTransactionIdentification;
        ReconciliationIdentification = reqReconciliationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of logical or physical operation on the ATM for which the counters are computed.
    /// </summary>
    [IsoId("_Q0orUOhBEeSbwP3G-MV9YA")]
    [DisplayName("Type Of Operation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfOpr")]
    #endif
    [IsoXmlTag("TpOfOpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMOperation1Code? TypeOfOperation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMOperation1Code? TypeOfOperation { get; init; } 
    #else
    public ATMOperation1Code? TypeOfOperation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation transaction.
    /// </summary>
    [IsoId("_7m03UOqREeSYnL2yvgmxmw")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the reconciliation period.
    /// </summary>
    [IsoId("_7j-qwItyEeSLQutgI1Ulfw")]
    [DisplayName("Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnId")]
    #endif
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ReconciliationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReconciliationIdentification { get; init; } 
    #else
    public System.String ReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_hZja1YtxEeSLQutgI1Ulfw")]
    [DisplayName("ATM Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMTtls")]
    #endif
    [IsoXmlTag("ATMTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTotals1? ATMTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTotals1? ATMTotals { get; init; } 
    #else
    public ATMTotals1? ATMTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the cassette of the ATM.
    /// </summary>
    [IsoId("_hZja14txEeSLQutgI1Ulfw")]
    [DisplayName("Cassette")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Csstt")]
    #endif
    [IsoXmlTag("Csstt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCassette1? Cassette { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCassette1? Cassette { get; init; } 
    #else
    public ATMCassette1? Cassette { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction counters that are set to zero after a reconciliation with counter reinitialisation command.
    /// </summary>
    [IsoId("_JH7X8ItzEeSLQutgI1Ulfw")]
    [DisplayName("Transaction Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTtls")]
    #endif
    [IsoXmlTag("TxTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMTotals3? TransactionTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMTotals3? TransactionTotals { get; init; } 
    #else
    public ATMTotals3? TransactionTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of retained cards.
    /// </summary>
    [IsoId("_zBBVwItzEeSLQutgI1Ulfw")]
    [DisplayName("Retained Card")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtndCard")]
    #endif
    [IsoXmlTag("RtndCard")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? RetainedCard { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RetainedCard { get; init; } 
    #else
    public System.UInt64? RetainedCard { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about reconciliation.
    /// </summary>
    [IsoId("_3eiC4ItzEeSLQutgI1Ulfw")]
    [DisplayName("Additional Transaction Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxInf")]
    #endif
    [IsoXmlTag("AddtlTxInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalTransactionInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalTransactionInformation { get; init; } 
    #else
    public System.String? AdditionalTransactionInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
