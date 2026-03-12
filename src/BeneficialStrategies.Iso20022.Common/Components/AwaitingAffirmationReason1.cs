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
[IsoId("_A6MM09okEeC60axPepSq7g_-1610048646")]
[DisplayName("Awaiting Affirmation Reason")]
public partial record AwaitingAffirmationReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the trade is wainting the affirmation.
    /// </summary>
    [IsoId("_A6MM1NokEeC60axPepSq7g_-1723887712")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required AwaitingAffirmationReason1Choice_ Code { get; init; } 
    
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_A6MM1dokEeC60axPepSq7g_1687846297")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
