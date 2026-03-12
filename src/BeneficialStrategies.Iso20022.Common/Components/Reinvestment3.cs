// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reinvestment information.
/// </summary>
[IsoId("_J1SUgU_dEeaB8-OWTiMVrQ")]
[DisplayName("Reinvestment")]
public partial record Reinvestment3
{
    #nullable enable
    
    /// <summary>
    /// Investment fund for the reinvestment.
    /// </summary>
    [IsoId("_KO35MU_dEeaB8-OWTiMVrQ")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument56 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_KO35M0_dEeaB8-OWTiMVrQ")]
    [DisplayName("Requested NAV Currency")]
    [IsoXmlTag("ReqdNAVCcy")]
    public ActiveCurrencyCode? RequestedNAVCurrency { get; init; } 
    
    /// <summary>
    /// Percentage of the reinvestment.
    /// </summary>
    [IsoId("_KO35NU_dEeaB8-OWTiMVrQ")]
    [DisplayName("Reinvestment Percentage")]
    [IsoXmlTag("RinvstmtPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate ReinvestmentPercentage { get; init; } 
    
    
    #nullable disable
    
}
