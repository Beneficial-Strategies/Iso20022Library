// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the baskets identification and the Eligibility Set Profile.
/// </summary>
[IsoId("_rh-hcLzTEeivTd4NUfCi2g")]
[DisplayName("Basket Identification And Eligibility Set Profile")]
public partial record BasketIdentificationAndEligibilitySetProfile1
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the preferred collateral basket.
    /// </summary>
    [IsoId("_uukj0LzUEeivTd4NUfCi2g")]
    [DisplayName("Preferential Basket Identification Number")]
    [IsoXmlTag("PrfrntlBsktIdNb")]
    public GenericIdentification1? PreferentialBasketIdentificationNumber { get; init; } 
    
    /// <summary>
    /// Number identifying the fallback starting collateral basket.
    /// </summary>
    [IsoId("_80k1MLzUEeivTd4NUfCi2g")]
    [DisplayName("Fallback Starting Basket Identification")]
    [IsoXmlTag("FllbckStartgBsktId")]
    public GenericIdentification1? FallbackStartingBasketIdentification { get; init; } 
    
    /// <summary>
    /// Number identifying the collateral basket to be excluded.
    /// </summary>
    [IsoId("_Nc55YLzVEeivTd4NUfCi2g")]
    [DisplayName("Exclusion Basket Identification")]
    [IsoXmlTag("ExclsnBsktId")]
    public GenericIdentification1? ExclusionBasketIdentification { get; init; } 
    
    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_UNrpoLzVEeivTd4NUfCi2g")]
    [DisplayName("Eligibility Set Profile")]
    [IsoXmlTag("ElgbltySetPrfl")]
    public GenericIdentification1? EligibilitySetProfile { get; init; } 
    
    
    #nullable disable
    
}
