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
/// Provides details on the status of the cancellation of a payment transaction.
/// </summary>
[IsoId("_jiiu0CX7Eei7VPGVFTQkxA")]
[DisplayName("Payment Transaction Cancellation Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentTransactionCancellationStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentTransactionCancellationStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentTransactionCancellationStatus1( CancellationIndividualStatus2Code reqTransactionCancellationStatus )
    {
        TransactionCancellationStatus = reqTransactionCancellationStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of a cancellation request.
    /// </summary>
    [IsoId("_yenskCX7Eei7VPGVFTQkxA")]
    [DisplayName("Transaction Cancellation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCxlSts")]
    #endif
    [IsoXmlTag("TxCxlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancellationIndividualStatus2Code TransactionCancellationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancellationIndividualStatus2Code TransactionCancellationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancellationIndividualStatus2Code TransactionCancellationStatus { get; init; } 
    #else
    public CancellationIndividualStatus2Code TransactionCancellationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
