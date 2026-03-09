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
/// Context in which the card transaction is performed.
/// </summary>
[IsoId("_LAygUHsHEeSR68OJvMfxJQ")]
[DisplayName("Card Transaction Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionContext1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionContext1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionContext1( CardTransactionContext2 reqTransactionContext )
    {
        TransactionContext = reqTransactionContext;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Context of the card transaction.
    /// </summary>
    [IsoId("_RunDMHsHEeSR68OJvMfxJQ")]
    [DisplayName("Transaction Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCntxt")]
    #endif
    [IsoXmlTag("TxCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardTransactionContext2 TransactionContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardTransactionContext2 TransactionContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardTransactionContext2 TransactionContext { get; init; } 
    #else
    public CardTransactionContext2 TransactionContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_XAcJMHsHEeSR68OJvMfxJQ")]
    [DisplayName("Sale Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleCntxt")]
    #endif
    [IsoXmlTag("SaleCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleContext1? SaleContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleContext1? SaleContext { get; init; } 
    #else
    public SaleContext1? SaleContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}
