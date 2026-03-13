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
[IsoId("_P7y45ZJKEeuAlLVx8pyt3w")]
[DisplayName("Business Error")]
public partial record BusinessError4
{
    #nullable enable
    
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_P-BGcZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Provides the business error.
    /// </summary>
    [IsoId("_P-BGc5JKEeuAlLVx8pyt3w")]
    [DisplayName("Business Error")]
    [IsoXmlTag("BizErr")]
    public ValueList<ErrorHandling5> BusinessError { get; init; } = [];
    // ID for the above is _P-BGc5JKEeuAlLVx8pyt3w
    
    
    #nullable disable
    
}
