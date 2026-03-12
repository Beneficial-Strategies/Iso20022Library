// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ability of a financial instrument to be easily traded and converted to cash, at conditions that do not affect its price.
/// </summary>
[IsoId("_SW_DgNp-Ed-ak6NoX_4Aeg_587026413")]
[DisplayName("Liquidity")]
public partial record Liquidity1
{
    #nullable enable
    
    /// <summary>
    /// Market value of the securities position for which liquidity details are provided.
    /// </summary>
    [IsoId("_SW_Dgdp-Ed-ak6NoX_4Aeg_962899324")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public ActiveCurrencyAndAmount? Value { get; init; } 
    
    /// <summary>
    /// Number of securities for which liquidity range details are provided.
    /// </summary>
    [IsoId("_SW_Dgtp-Ed-ak6NoX_4Aeg_889017115")]
    [DisplayName("Number Of Securities")]
    [IsoXmlTag("NbOfScties")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? NumberOfSecurities { get; init; } 
    
    /// <summary>
    /// Upper liquidity indicator, represented as a percentage of the average trade daily volume.
    /// </summary>
    [IsoId("_SW_Dg9p-Ed-ak6NoX_4Aeg_901945694")]
    [DisplayName("Upper")]
    [IsoXmlTag("Upper")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Upper { get; init; } 
    
    /// <summary>
    /// Lower liquidity indicator, represented as a percentage of the average trade daily volume.
    /// </summary>
    [IsoId("_SW_DhNp-Ed-ak6NoX_4Aeg_917645433")]
    [DisplayName("Lower")]
    [IsoXmlTag("Lwr")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Lower { get; init; } 
    
    
    #nullable disable
    
}
