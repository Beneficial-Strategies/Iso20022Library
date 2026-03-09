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
/// Hierarchy of classification of a derivative.
/// </summary>
[IsoId("_B4WEgMhtEeadgvwNGwK05w")]
[DisplayName("Derivative Classification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DerivativeClassification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DerivativeClassification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DerivativeClassification1( System.String reqAssetClass )
    {
        AssetClass = reqAssetClass;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Highest level classification of a derivative.
    /// </summary>
    [IsoId("_ImD5sMhtEeadgvwNGwK05w")]
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
    /// Second level classification of a derivative.
    /// </summary>
    [IsoId("_Jb1rIMhtEeadgvwNGwK05w")]
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
    /// Third level classification of a derivative.
    /// </summary>
    [IsoId("_KRGfMMhtEeadgvwNGwK05w")]
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
    /// Low level classification of commodity derivatives.
    /// </summary>
    [IsoId("_MFkGcMhtEeadgvwNGwK05w")]
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
    /// Low level classification of a derivative.
    /// </summary>
    [IsoId("_M9Kc0MhtEeadgvwNGwK05w")]
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
