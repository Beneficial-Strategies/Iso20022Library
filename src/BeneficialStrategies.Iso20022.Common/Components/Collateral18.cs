// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the security pledge as collateral.
/// </summary>
[IsoId("_96huocEaEea7jLfvGi1PDw")]
[DisplayName("Collateral")]
public partial record Collateral18
{
    #nullable enable
    
    /// <summary>
    /// Provides the values of the security pledged as collateral.
    /// </summary>
    [IsoId("_-DKGMcEaEea7jLfvGi1PDw")]
    [DisplayName("Valuation")]
    [IsoXmlTag("Valtn")]
    public required SecuredCollateral2Choice_ Valuation { get; init; } 
    
    /// <summary>
    /// Risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
    /// For reporting purposes the collateral haircut will be calculated as 100 minus the ratio between the cash lent/borrowed and the market value including accrued interest of the collateral pledged times 100. 
    /// In the case of multi-collateral repos the haircut will be based on the ratio between the cash borrowed/lent and the market value, including accrued interest of each of the individual collateral pledged. 
    /// Only actual values, as opposed to estimated or default values will be reported for this variable.
    /// </summary>
    [IsoId("_-DKGM8EaEea7jLfvGi1PDw")]
    [DisplayName("Haircut")]
    [IsoXmlTag("Hrcut")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Haircut { get; init; } 
    
    /// <summary>
    /// Identifies all repurchase agreements conducted against general collateral, those conducted against special collateral and securities lending transactions made of matched repurchase agreements and reverse repurchase agreements transacted versus cash.
    /// - General Collateral is a repurchase transaction in which the security lender may choose the security to pledge as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria; 
    /// - Special Collateral is a repurchase transaction in which the cash provider requests a specific security (individual ISIN) to be provided by the cash borrower;
    /// - Matched and Reverse Repurchase Agreement is a securities lending transaction as defined by local market practices. 
    /// Usage:
    /// This field is optional and it should be provided only in case it is feasible for the reporting agent.
    /// </summary>
    [IsoId("_-DKGNcEaEea7jLfvGi1PDw")]
    [DisplayName("Special Collateral Indicator")]
    [IsoXmlTag("SpclCollInd")]
    public SpecialCollateral2Code? SpecialCollateralIndicator { get; init; } 
    
    
    #nullable disable
    
}
