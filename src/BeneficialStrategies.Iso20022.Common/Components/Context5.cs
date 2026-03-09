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
[IsoId("_tdRDod8PEeeNTcLLmuYy-w")]
[DisplayName("Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Context5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Context5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Context5( PointOfServiceContext1 reqPointOfServiceContext,TransactionContext1 reqTransactionContext )
    {
        PointOfServiceContext = reqPointOfServiceContext;
        TransactionContext = reqTransactionContext;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_tsa58d8PEeeNTcLLmuYy-w")]
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
    [IsoId("_tsa5898PEeeNTcLLmuYy-w")]
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
    /// Method and data intended to be used for this transaction in order to authenticate or verify the cardholder or his card.
    /// </summary>
    [IsoId("_tsa59d8PEeeNTcLLmuYy-w")]
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
    [IsoId("_tsa5998PEeeNTcLLmuYy-w")]
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
    
    
    #nullable disable
    
}
