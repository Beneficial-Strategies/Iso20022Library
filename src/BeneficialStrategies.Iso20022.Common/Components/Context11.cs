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
[IsoId("_SZeAkYN1EeuHqfO1LgkE9Q")]
[DisplayName("Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Context11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Context11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Context11( PointOfServiceContext3 reqPointOfServiceContext,TransactionContext7 reqTransactionContext )
    {
        PointOfServiceContext = reqPointOfServiceContext;
        TransactionContext = reqTransactionContext;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_SeCXgYN1EeuHqfO1LgkE9Q")]
    [DisplayName("Point Of Service Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtOfSvcCntxt")]
    #endif
    [IsoXmlTag("PtOfSvcCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfServiceContext3 PointOfServiceContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PointOfServiceContext3 PointOfServiceContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfServiceContext3 PointOfServiceContext { get; init; } 
    #else
    public PointOfServiceContext3 PointOfServiceContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_SeCXg4N1EeuHqfO1LgkE9Q")]
    [DisplayName("Transaction Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCntxt")]
    #endif
    [IsoXmlTag("TxCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionContext7 TransactionContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionContext7 TransactionContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionContext7 TransactionContext { get; init; } 
    #else
    public TransactionContext7 TransactionContext { get; set; } 
    #endif
    
    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify the cardholder or his card.
    /// </summary>
    [IsoId("_SeCXhYN1EeuHqfO1LgkE9Q")]
    [DisplayName("Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrfctn")]
    #endif
    [IsoXmlTag("Vrfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Verification5? Verification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Verification5? Verification { get; init; } 
    #else
    public Verification5? Verification { get; set; } 
    #endif
    
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_SeCXh4N1EeuHqfO1LgkE9Q")]
    [DisplayName("Risk Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RskCntxt")]
    #endif
    [IsoXmlTag("RskCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskContext2? RiskContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskContext2? RiskContext { get; init; } 
    #else
    public RiskContext2? RiskContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}
