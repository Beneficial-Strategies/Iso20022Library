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
/// Information on collateral used in the transaction.
/// </summary>
[IsoId("_8epooQABEeqefbt-QjTNnA")]
[DisplayName("Collateral Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralData27
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    [IsoId("_8jwyIQABEeqefbt-QjTNnA")]
    [DisplayName("Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstTp")]
    #endif
    [IsoXmlTag("AsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType14? AssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType14? AssetType { get; init; } 
    #else
    public CollateralType14? AssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    [IsoId("_8jwyIwABEeqefbt-QjTNnA")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetXpsrCollstnInd")]
    #endif
    [IsoXmlTag("NetXpsrCollstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NetExposureCollateralisationIndicator { get; init; } 
    #else
    public System.String? NetExposureCollateralisationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the collateral basket.
    /// </summary>
    [IsoId("_8jwyJQABEeqefbt-QjTNnA")]
    [DisplayName("Basket Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsktIdr")]
    #endif
    [IsoXmlTag("BsktIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
    #else
    public SecurityIdentification26Choice_? BasketIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
