// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specify the ISIN(s) and / or LEI(s) that are present in a basket.
/// </summary>
[IsoId("_a46r4PBqEeWTAY6i--T_aA")]
[DisplayName("Financial Instrument")]
public partial record FinancialInstrument53
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_a46r4fBqEeWTAY6i--T_aA")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    public IsoISINOct2015Identifier? ISIN { get; init; } 
    
    /// <summary>
    /// The LEI code of the issuer where the instrument is referring to an issuer rather than one single instrument.
    /// </summary>
    [IsoId("_a46r4vBqEeWTAY6i--T_aA")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    
    #nullable disable
    
}
