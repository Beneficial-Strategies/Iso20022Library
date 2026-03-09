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
/// Card payment transaction including an authorisation response.
/// </summary>
[IsoId("_rqzskap2EeanIZ10Ka8PnA")]
[DisplayName("Card Payment Data Set Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentDataSetTransaction21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentDataSetTransaction21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentDataSetTransaction21( System.String reqTransactionSequenceCounter,CardPaymentEnvironment66 reqEnvironment,CardPaymentTransaction78 reqTransaction,CardPaymentTransaction67 reqTransactionResponse )
    {
        TransactionSequenceCounter = reqTransactionSequenceCounter;
        Environment = reqEnvironment;
        Transaction = reqTransaction;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential counter of the transaction.
    /// </summary>
    [IsoId("_r17-gap2EeanIZ10Ka8PnA")]
    [DisplayName("Transaction Sequence Counter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSeqCntr")]
    #endif
    [IsoXmlTag("TxSeqCntr")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax9NumericText TransactionSequenceCounter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionSequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionSequenceCounter { get; init; } 
    #else
    public System.String TransactionSequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of partners involved in the exchange from the merchant to the issuer, with the corresponding timestamp of their exchanges.
    /// </summary>
    [IsoId("_r17-g6p2EeanIZ10Ka8PnA")]
    [DisplayName("Traceability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tracblt")]
    #endif
    [IsoXmlTag("Tracblt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Traceability5? Traceability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Traceability5? Traceability { get; init; } 
    #else
    public Traceability5? Traceability { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the environment of the card payment transaction.
    /// </summary>
    [IsoId("_r17-hap2EeanIZ10Ka8PnA")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment66 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment66 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment66 Environment { get; init; } 
    #else
    public CardPaymentEnvironment66 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Card payment transaction authorisation result.
    /// </summary>
    [IsoId("_r17-h6p2EeanIZ10Ka8PnA")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction78 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentTransaction78 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction78 Transaction { get; init; } 
    #else
    public CardPaymentTransaction78 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Response to the authorisation request from the acquirer.
    /// </summary>
    [IsoId("_r17-iap2EeanIZ10Ka8PnA")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction67 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentTransaction67 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction67 TransactionResponse { get; init; } 
    #else
    public CardPaymentTransaction67 TransactionResponse { get; set; } 
    #endif
    
    
    #nullable disable
    
}
