// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the security instrument by its name and typical characteristics.
/// </summary>
[IsoId("_KUIpdYG-EeaalK9UbuVGFw")]
[DisplayName("Security Instrument Description")]
public partial record SecurityInstrumentDescription13
{
    #nullable enable
    
    /// <summary>
    /// Attributes and characteristics of the financial instrument.
    /// </summary>
    [IsoId("_KeZ_wYG-EeaalK9UbuVGFw")]
    [DisplayName("Financial Instrument General Attributes")]
    [IsoXmlTag("FinInstrmGnlAttrbts")]
    public required SecurityInstrumentDescription11 FinancialInstrumentGeneralAttributes { get; init; } 
    
    /// <summary>
    /// Attributes specific to debt instruments.
    /// </summary>
    [IsoId("_KeZ_w4G-EeaalK9UbuVGFw")]
    [DisplayName("Debt Instrument Attributes")]
    [IsoXmlTag("DebtInstrmAttrbts")]
    public DebtInstrument4? DebtInstrumentAttributes { get; init; } 
    
    /// <summary>
    /// Attributes specific to derivative instruments.
    /// </summary>
    [IsoId("_KeZ_xYG-EeaalK9UbuVGFw")]
    [DisplayName("Derivative Instrument Attributes")]
    [IsoXmlTag("DerivInstrmAttrbts")]
    public required DerivativeInstrument6 DerivativeInstrumentAttributes { get; init; } 
    
    
    #nullable disable
    
}
