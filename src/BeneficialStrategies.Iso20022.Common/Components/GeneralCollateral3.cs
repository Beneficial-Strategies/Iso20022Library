// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Repurchase agreement where the agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
/// </summary>
[IsoId("_M0GsEeoaEeadseq5W5YLvQ")]
[DisplayName("General Collateral")]
public partial record GeneralCollateral3
{
    #nullable enable
    
    /// <summary>
    /// ISINs of allocated securities of general collateral where known.
    /// </summary>
    [IsoId("_plT7AfnbEeaHA8tUPpXMKA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public FinancialInstrument59? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// List of eligible securities to be allocated where known.
    /// </summary>
    [IsoId("_M-XbUeoaEeadseq5W5YLvQ")]
    [DisplayName("Eligible Financial Instrument Identification")]
    [IsoXmlTag("ElgblFinInstrmId")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? EligibleFinancialInstrumentIdentification { get; init; } 
    
    
    #nullable disable
    
}
