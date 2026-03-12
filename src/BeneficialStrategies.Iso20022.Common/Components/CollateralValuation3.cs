// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the valuation of a collateral, identified through an ISIN.
/// </summary>
[IsoId("_bQ9goZf6EeSfnc-VXAEapg")]
[DisplayName("Collateral Valuation")]
public partial record CollateralValuation3
{
    #nullable enable
    
    /// <summary>
    /// Nominal amount of the security pledged as collateral. Except for tri-party repos and any other transaction in which the security pledged is not identified via a single ISIN.
    /// </summary>
    [IsoId("_m6QfAZf6EeSfnc-VXAEapg")]
    [DisplayName("Nominal Amount")]
    [IsoXmlTag("NmnlAmt")]
    public ActiveCurrencyAndAmount? NominalAmount { get; init; } 
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_uqx1AZf6EeSfnc-VXAEapg")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    public required IsoISINIdentifier ISIN { get; init; } 
    
    
    #nullable disable
    
}
