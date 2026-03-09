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
/// Specifies attributes of a derivative based on Final ISDA Taxonomy v1.0 and Final ISDA Taxonomy v2.0 (https://www.isda.org/2018/02/20/final-isda-taxonomy-v1-0-and-final-isda-taxonomy-v2-0/).
/// </summary>
[IsoId("_M00DgDXHEemdWfjs3tykFQ")]
[DisplayName("Product Classification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProductClassification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProductClassification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProductClassification1( System.String reqAssetClass )
    {
        AssetClass = reqAssetClass;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Asset class of the underlying of the derivative (e.g. Interest Rate, Commodity, Equity).
    /// </summary>
    [IsoId("_WPDJUDXHEemdWfjs3tykFQ")]
    [DisplayName("Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClss")]
    #endif
    [IsoXmlTag("AsstClss")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AssetClass { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AssetClass { get; init; } 
    #else
    public System.String AssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Market of the underlying product (IR Swap, Freight, Precious/Non Precious).
    /// </summary>
    [IsoId("_YzAT0DXHEemdWfjs3tykFQ")]
    [DisplayName("Base Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BasePdct")]
    #endif
    [IsoXmlTag("BasePdct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BaseProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BaseProduct { get; init; } 
    #else
    public System.String? BaseProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Further details of the product type.
    /// </summary>
    [IsoId("_bSfOADXHEemdWfjs3tykFQ")]
    [DisplayName("Sub Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPdct")]
    #endif
    [IsoXmlTag("SubPdct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubProduct { get; init; } 
    #else
    public System.String? SubProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Further details if the asset class is commodity.
    /// </summary>
    [IsoId("_d65asDXHEemdWfjs3tykFQ")]
    [DisplayName("Sub Commodity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubCmmdty")]
    #endif
    [IsoXmlTag("SubCmmdty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubCommodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubCommodity { get; init; } 
    #else
    public System.String? SubCommodity { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the transaction, for example, option, spot forward or exotic.
    /// </summary>
    [IsoId("_gLqjcDXHEemdWfjs3tykFQ")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionType { get; init; } 
    #else
    public System.String? TransactionType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
