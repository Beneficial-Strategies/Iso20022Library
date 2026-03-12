// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on collateral used in the transaction.
/// </summary>
[IsoId("_8epooQABEeqefbt-QjTNnA")]
[DisplayName("Collateral Data")]
public partial record CollateralData27
{
    #nullable enable
    
    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    [IsoId("_8jwyIQABEeqefbt-QjTNnA")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public CollateralType14? AssetType { get; init; } 
    
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    [IsoId("_8jwyIwABEeqefbt-QjTNnA")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    [IsoXmlTag("NetXpsrCollstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the collateral basket.
    /// </summary>
    [IsoId("_8jwyJQABEeqefbt-QjTNnA")]
    [DisplayName("Basket Identifier")]
    [IsoXmlTag("BsktIdr")]
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
    
    
    #nullable disable
    
}
