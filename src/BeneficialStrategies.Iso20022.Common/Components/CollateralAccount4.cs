// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information on the collateral account of the party delivering/receiving the collateral.
/// </summary>
[IsoId("_0esxkK_8EeaE9YROwd69hA")]
[DisplayName("Collateral Account")]
public partial record CollateralAccount4
{
    #nullable enable
    
    /// <summary>
    /// Identification of the collateral account.
    /// </summary>
    [IsoId("_BBT9k6_9EeaE9YROwd69hA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required GenericIdentification165 Identification { get; init; } 
    
    /// <summary>
    /// Specifies the financial instruments placed as collateral.
    /// </summary>
    [IsoId("_BBT9la_9EeaE9YROwd69hA")]
    [DisplayName("Asset Holding")]
    [IsoXmlTag("AsstHldg")]
    public ValueList<AssetHolding1> AssetHolding { get; init; } = new ValueList<AssetHolding1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _BBT9la_9EeaE9YROwd69hA
    
    
    #nullable disable
    
}
