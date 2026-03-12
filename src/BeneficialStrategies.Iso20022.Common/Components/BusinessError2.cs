// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the business error details.
/// </summary>
[IsoId("_hDSckeL6EeWOD7aAy2fAcA")]
[DisplayName("Business Error")]
public partial record BusinessError2
{
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_hOcjseL6EeWOD7aAy2fAcA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Provides the business error.
    /// </summary>
    [IsoId("_hOcjs-L6EeWOD7aAy2fAcA")]
    [DisplayName("Business Error")]
    [IsoXmlTag("BizErr")]
    public ValueList<ErrorHandling4> BusinessError { get; init; } = new ValueList<ErrorHandling4>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _hOcjs-L6EeWOD7aAy2fAcA
    
    
    #nullable disable
    
}
