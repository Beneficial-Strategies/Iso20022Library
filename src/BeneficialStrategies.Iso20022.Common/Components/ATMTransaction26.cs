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
/// Information about the reconciliation response.
/// </summary>
[IsoId("_iiJCga48EeWRfYPBaeOY8w")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction26 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction26( TransactionIdentifier1 reqTransactionIdentification,System.String reqReconciliationIdentification,ResponseType7 reqTransactionResponse )
    {
        TransactionIdentification = reqTransactionIdentification;
        ReconciliationIdentification = reqReconciliationIdentification;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of logical or physical operation on the ATM for which the counters are computed.
    /// </summary>
    [IsoId("_iskw4a48EeWRfYPBaeOY8w")]
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
    [IsoId("_iskw4648EeWRfYPBaeOY8w")]
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
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    [IsoId("_iskw5a48EeWRfYPBaeOY8w")]
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
    /// Result of the reconciliation.
    /// </summary>
    [IsoId("_iskw5648EeWRfYPBaeOY8w")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType7 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType7 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType7 TransactionResponse { get; init; } 
    #else
    public ResponseType7 TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    [IsoId("_uEGp0K48EeWRfYPBaeOY8w")]
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
    /// Information on the cassettes of the ATM.
    /// </summary>
    [IsoId("_36_PYK48EeWRfYPBaeOY8w")]
    [DisplayName("Cassette")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Csstt")]
    #endif
    [IsoXmlTag("Csstt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCassette2? Cassette { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCassette2? Cassette { get; init; } 
    #else
    public ATMCassette2? Cassette { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_iskw6a48EeWRfYPBaeOY8w")]
    [DisplayName("Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmd")]
    #endif
    [IsoXmlTag("Cmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand7? Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand7? Command { get; init; } 
    #else
    public ATMCommand7? Command { get; set; } 
    #endif
    
    
    #nullable disable
    
}
