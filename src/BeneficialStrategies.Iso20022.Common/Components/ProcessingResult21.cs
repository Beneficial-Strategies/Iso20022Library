// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the processing of the authorisation.
/// </summary>
[IsoId("_b_P7oShTEeyhZIgCcGlTyA")]
[DisplayName("Processing Result")]
public partial record ProcessingResult21
{
    #nullable enable
    
    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_cDKLQShTEeyhZIgCcGlTyA")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public ResultData7? ResultData { get; init; } 
    
    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_cDKLQyhTEeyhZIgCcGlTyA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation29? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
