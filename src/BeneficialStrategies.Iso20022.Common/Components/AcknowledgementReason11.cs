// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
[IsoId("_YBdO6zq1EeWyoP0PbocV1Q")]
[DisplayName("Acknowledgement Reason")]
public partial record AcknowledgementReason11
{
    #nullable enable
    
    /// <summary>
    /// Choice of format for the acknowledgement reason.
    /// </summary>
    [IsoId("_YhcWgTq1EeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AcknowledgementReason14Choice_ Code { get; init; } 
    
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_YhcWgzq1EeWyoP0PbocV1Q")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
