// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the collateral used in the transaction.
/// </summary>
[IsoId("_pzQL4c6fEeuUrZNOIIJRog")]
[DisplayName("Collateral Data")]
public partial record CollateralData35
{
    #nullable enable
    
    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    [IsoId("_p1RlIc6fEeuUrZNOIIJRog")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public CollateralType21? AssetType { get; init; } 
    
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    [IsoId("_p1RlI86fEeuUrZNOIIJRog")]
    [DisplayName("Net Exposure Collateralisation Indicator")]
    [IsoXmlTag("NetXpsrCollstnInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the collateral basket.
    /// </summary>
    [IsoId("_p1RlJc6fEeuUrZNOIIJRog")]
    [DisplayName("Basket Identifier")]
    [IsoXmlTag("BsktIdr")]
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
    
    
    #nullable disable
    
}
