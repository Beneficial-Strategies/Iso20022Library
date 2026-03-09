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
/// Reconciliation response from the acquirer.
/// </summary>
[IsoId("_e1P4UN51EeeCre2qFaLC2A")]
[DisplayName("Acceptor Reconciliation Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorReconciliationResponse5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorReconciliationResponse5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorReconciliationResponse5( CardPaymentEnvironment69 reqEnvironment,ResponseType5 reqTransactionResponse,TransactionReconciliation4 reqTransaction )
    {
        Environment = reqEnvironment;
        TransactionResponse = reqTransactionResponse;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_fArFMd51EeeCre2qFaLC2A")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment69 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment69 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment69 Environment { get; init; } 
    #else
    public CardPaymentEnvironment69 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    [IsoId("_fArFM951EeeCre2qFaLC2A")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType5 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType5 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType5 TransactionResponse { get; init; } 
    #else
    public ResponseType5 TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    [IsoId("_fArFNd51EeeCre2qFaLC2A")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionReconciliation4 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionReconciliation4 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionReconciliation4 Transaction { get; init; } 
    #else
    public TransactionReconciliation4 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
