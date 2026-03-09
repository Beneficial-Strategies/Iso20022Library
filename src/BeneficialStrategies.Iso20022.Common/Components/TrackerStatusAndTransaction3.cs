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
/// Provides detailed information on the transaction and it&apos;s status to be updated in the tracker.
/// </summary>
[IsoId("_XZ_N8_WfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Status And Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerStatusAndTransaction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerStatusAndTransaction3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerStatusAndTransaction3( TrackerStatus3 reqTransactionStatus,TrackerPaymentTransaction3 reqTransaction )
    {
        TransactionStatus = reqTransactionStatus;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    [IsoId("_XZ_N9_WfEemtd4wHZYvFUQ")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerStatus3 TransactionStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerStatus3 TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerStatus3 TransactionStatus { get; init; } 
    #else
    public TrackerStatus3 TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    [IsoId("_XZ_N-fWfEemtd4wHZYvFUQ")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerPaymentTransaction3 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerPaymentTransaction3 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPaymentTransaction3 Transaction { get; init; } 
    #else
    public TrackerPaymentTransaction3 Transaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
