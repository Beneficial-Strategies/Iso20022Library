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
[IsoId("_hW9wV2liEeGaMcKyqKNRfQ_1431206011")]
[DisplayName("Business Error")]
public partial record BusinessError1
{
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_hW9wWGliEeGaMcKyqKNRfQ_536353207")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Provides the business error.
    /// </summary>
    [IsoId("_hW9wWWliEeGaMcKyqKNRfQ_-1167546325")]
    [DisplayName("Business Error")]
    [IsoXmlTag("BizErr")]
    public ValueList<ErrorHandling3> BusinessError { get; init; } = new ValueList<ErrorHandling3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _hW9wWWliEeGaMcKyqKNRfQ_-1167546325
    
    
    #nullable disable
    
}
