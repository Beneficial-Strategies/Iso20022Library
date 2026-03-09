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
[IsoId("_IRz0cVZpEeeFltjJxERUxw")]
[DisplayName("Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Context4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Context4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Context4( TransactionContext3 reqTransactionContext )
    {
        TransactionContext = reqTransactionContext;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction at the point of service.
    /// </summary>
    [IsoId("_IDx3gewHEeiMkKo2clXHdQ")]
    [DisplayName("Point Of Service Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtOfSvcCntxt")]
    #endif
    [IsoXmlTag("PtOfSvcCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfServiceContext2? PointOfServiceContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfServiceContext2? PointOfServiceContext { get; init; } 
    #else
    public PointOfServiceContext2? PointOfServiceContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the transaction.
    /// </summary>
    [IsoId("_bU7OIFZrEeeFltjJxERUxw")]
    [DisplayName("Transaction Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCntxt")]
    #endif
    [IsoXmlTag("TxCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionContext3 TransactionContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionContext3 TransactionContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionContext3 TransactionContext { get; init; } 
    #else
    public TransactionContext3 TransactionContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the sale associated with the card payment transaction.
    /// </summary>
    [IsoId("_IdQ2iVZpEeeFltjJxERUxw")]
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
