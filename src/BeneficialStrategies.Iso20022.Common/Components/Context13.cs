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
[IsoId("_61__UahMEeuOaMA1YOy5YQ")]
[DisplayName("Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Context13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains point of interaction information specific to a given transaction that may change from transaction to transaction.
    /// </summary>
    [IsoId("_67DecahMEeuOaMA1YOy5YQ")]
    [DisplayName("Point Of Service Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtOfSvcCntxt")]
    #endif
    [IsoXmlTag("PtOfSvcCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfServiceContext4? PointOfServiceContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfServiceContext4? PointOfServiceContext { get; init; } 
    #else
    public PointOfServiceContext4? PointOfServiceContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_67Dec6hMEeuOaMA1YOy5YQ")]
    [DisplayName("Transaction Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCntxt")]
    #endif
    [IsoXmlTag("TxCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionContext8? TransactionContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionContext8? TransactionContext { get; init; } 
    #else
    public TransactionContext8? TransactionContext { get; set; } 
    #endif
    
    /// <summary>
    /// Method and data intended to be used for this transaction in order to authenticate or verify  the cardholder or his card.
    /// </summary>
    [IsoId("_67DedahMEeuOaMA1YOy5YQ")]
    [DisplayName("Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrfctn")]
    #endif
    [IsoXmlTag("Vrfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Verification4? Verification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Verification4? Verification { get; init; } 
    #else
    public Verification4? Verification { get; set; } 
    #endif
    
    /// <summary>
    /// Context of risk associated with the transaction.
    /// </summary>
    [IsoId("_67Ded6hMEeuOaMA1YOy5YQ")]
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
