// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
[IsoId("_A4QTItokEeC60axPepSq7g_582343091")]
[DisplayName("Awaiting Cancellation Reason")]
public partial record AwaitingCancellationReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the trade is wainting the cancellation.
    /// </summary>
    [IsoId("_A4QTI9okEeC60axPepSq7g_468504025")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AwaitingCancellationReason1Choice_ Code { get; init; } 
    
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_A4QTJNokEeC60axPepSq7g_-414729262")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
