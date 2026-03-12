// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
/// </summary>
[IsoId("_MwencVfdEeqZr5K1Woax-g")]
[DisplayName("Rejection Statistics")]
public partial record RejectionStatistics3
{
    #nullable enable
    
    /// <summary>
    /// Total number of derivatives submitted by the report submitting entity for the reporting counterparty which failed to pass technical schema validations.
    /// </summary>
    [IsoId("_NHlf4VfdEeqZr5K1Woax-g")]
    [DisplayName("Total Number Of Technical Rejections")]
    [IsoXmlTag("TtlNbOfTechRjctns")]
    [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
    public required IsoMax20PositiveNumber TotalNumberOfTechnicalRejections { get; init; } 
    
    /// <summary>
    /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass data validations.
    /// </summary>
    [IsoId("_NHlf41fdEeqZr5K1Woax-g")]
    [DisplayName("Derivatives Statistics")]
    [IsoXmlTag("DerivsSttstcs")]
    public required DerivativesStatistics3 DerivativesStatistics { get; init; } 
    
    
    #nullable disable
    
}
