// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tangible items of value to a business.
/// </summary>
[IsoId("_PxlM8ZJKEeuAlLVx8pyt3w")]
[DisplayName("Security Attributes")]
public partial record SecurityAttributes10
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security.
    /// </summary>
    [IsoId("_PzlYEZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Provides additional details about the financial instrument.
    /// </summary>
    [IsoId("_PzlYE5JKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Type")]
    [IsoXmlTag("FinInstrmTp")]
    public FinancialInstrument97? FinancialInstrumentType { get; init; } 
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_PzlYFZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public CommonFinancialInstrumentAttributes10? FinancialInstrumentAttributes { get; init; } 
    
    
    #nullable disable
    
}
