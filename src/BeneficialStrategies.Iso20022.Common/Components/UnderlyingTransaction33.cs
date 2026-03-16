// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Underlying Transaction33.
/// </summary>
[IsoId("_9c2ggTEsEe6GxLzpkVnWYg")]
[DisplayName("Underlying Transaction33")]
public partial record UnderlyingTransaction33
{
    #nullable enable

    /// <summary>
    /// Original Group Information And Cancellation.
    /// </summary>
    [DisplayName("Original Group Information And Cancellation")]
    [IsoXmlTag("OrgnlGrpInfAndCxl")]
    public OriginalGroupHeader21? OriginalGroupInformationAndCancellation { get; init; } 

    /// <summary>
    /// Original Payment Information And Cancellation.
    /// </summary>
    [DisplayName("Original Payment Information And Cancellation")]
    [IsoXmlTag("OrgnlPmtInfAndCxl")]
    public ValueList<OriginalPaymentInstruction49> OriginalPaymentInformationAndCancellation { get; init; } = [];

    
    #nullable disable
    
}
