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
/// Context in which the card payment transaction is performed.
/// </summary>
[IsoId("_qDPEQEbWEeeIjf8aP9KbJA")]
[DisplayName("Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Context1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Context1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Context1( PointOfServiceContext1 reqPointOfServiceContext,TransactionContext1 reqTransactionContext )
    {
        PointOfServiceContext = reqPointOfServiceContext;
        TransactionContext = reqTransactionContext;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    [IsoId("_8Q-nEEbWEeeIjf8aP9KbJA")]
    [DisplayName("Point Of Service Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtOfSvcCntxt")]
    #endif
    [IsoXmlTag("PtOfSvcCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfServiceContext1 PointOfServiceContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfServiceContext1 PointOfServiceContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfServiceContext1 PointOfServiceContext { get; init; } 
    #else
    public PointOfServiceContext1 PointOfServiceContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_G7Y7UEbXEeeIjf8aP9KbJA")]
    [DisplayName("Transaction Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCntxt")]
    #endif
    [IsoXmlTag("TxCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionContext1 TransactionContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionContext1 TransactionContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionContext1 TransactionContext { get; init; } 
    #else
    public TransactionContext1 TransactionContext { get; set; } 
    #endif
    
    /// <summary>
    /// Contain validation result and/or data to be validated.
    /// </summary>
    [IsoId("_kSCoEEbeEeeIjf8aP9KbJA")]
    [DisplayName("Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrfctn")]
    #endif
    [IsoXmlTag("Vrfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Verification1? Verification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Verification1? Verification { get; init; } 
    #else
    public Verification1? Verification { get; set; } 
    #endif
    
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_uRO1EEbeEeeIjf8aP9KbJA")]
    [DisplayName("Risk Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskCntxt")]
    #endif
    [IsoXmlTag("RskCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskContext1? RiskContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskContext1? RiskContext { get; init; } 
    #else
    public RiskContext1? RiskContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_6W8CoEbeEeeIjf8aP9KbJA")]
    [DisplayName("Sale Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleCntxt")]
    #endif
    [IsoXmlTag("SaleCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleContext7? SaleContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleContext7? SaleContext { get; init; } 
    #else
    public SaleContext7? SaleContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}
