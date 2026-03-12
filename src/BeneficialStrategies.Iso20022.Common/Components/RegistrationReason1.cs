// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason of registration.
/// </summary>
[IsoId("_xoFroEAbEeC4mKrqv7wPJQ")]
[DisplayName("Registration Reason")]
public partial record RegistrationReason1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reaoson of the holding status.
    /// </summary>
    [IsoId("_ACDbP0AcEeC4mKrqv7wPJQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required Registration3Choice_ Code { get; init; } 
    
    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_ovxx10AcEeC4mKrqv7wPJQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
