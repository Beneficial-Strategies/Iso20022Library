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
/// Provides details on the payment transactions.
/// </summary>
[IsoId("_8WqD8QKxEe2rHs6fbn9-0A")]
[DisplayName("Transaction Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionReport7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionReport7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionReport7( PaymentIdentification7Choice_ reqPaymentIdentification,TransactionOrError5Choice_ reqTransactionOrError )
    {
        PaymentIdentification = reqPaymentIdentification;
        TransactionOrError = reqTransactionOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    [IsoId("_8_jP8QKxEe2rHs6fbn9-0A")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification7Choice_ PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the payment transaction when information has not been found.
    /// </summary>
    [IsoId("_8_jP8wKxEe2rHs6fbn9-0A")]
    [DisplayName("Transaction Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxOrErr")]
    #endif
    [IsoXmlTag("TxOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionOrError5Choice_ TransactionOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionOrError5Choice_ TransactionOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionOrError5Choice_ TransactionOrError { get; init; } 
    #else
    public TransactionOrError5Choice_ TransactionOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
