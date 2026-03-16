// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Reversal Reason8.
/// </summary>
[IsoId("_EWlOMYCzEe-3UrLQHGsjgQ")]
[DisplayName("Corporate Action Reversal Reason8")]
public partial record CorporateActionReversalReason8
{
    #nullable enable

    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax256Text? AdditionalReasonInformation { get; init; } 

    /// <summary>
    /// Reason.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CorporateActionReversalReason10Choice_ Reason { get; init; } 

    
    #nullable disable
    
}
