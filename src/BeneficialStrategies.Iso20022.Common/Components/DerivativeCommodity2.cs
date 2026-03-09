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
/// Defines the details of a commodity derivative.
/// </summary>
[IsoId("_e-bjmXvyEeanCNPcMT7sSg")]
[DisplayName("Derivative Commodity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeCommodity2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativeCommodity2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativeCommodity2( AssetClassCommodity3Choice_ reqProduct )
    {
        Product = reqProduct;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Commodity product attributes.
    /// </summary>
    [IsoId("_fHZ5YXvyEeanCNPcMT7sSg")]
    [DisplayName("Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pdct")]
    #endif
    [IsoXmlTag("Pdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassCommodity3Choice_ Product { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetClassCommodity3Choice_ Product { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassCommodity3Choice_ Product { get; init; } 
    #else
    public AssetClassCommodity3Choice_ Product { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction type as specified by the trading venue.
    /// </summary>
    [IsoId("_fHZ5Y3vyEeanCNPcMT7sSg")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassTransactionType1Code? TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassTransactionType1Code? TransactionType { get; init; } 
    #else
    public AssetClassTransactionType1Code? TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Final price type as specified by the trading venue.
    /// </summary>
    [IsoId("_fHZ5ZXvyEeanCNPcMT7sSg")]
    [DisplayName("Final Price Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlPricTp")]
    #endif
    [IsoXmlTag("FnlPricTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetPriceType1Code? FinalPriceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetPriceType1Code? FinalPriceType { get; init; } 
    #else
    public AssetPriceType1Code? FinalPriceType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
