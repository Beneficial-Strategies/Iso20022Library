// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of missing information.
/// </summary>
[IsoId("_fXkdxUgoEeaGKYpLDboHPQ")]
[DisplayName("Unable To Apply Missing")]
public partial record UnableToApplyMissing1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the missing information in a coded form.
    /// </summary>
    [IsoId("_fXkdyEgoEeaGKYpLDboHPQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required UnableToApplyMissingInformation3Code Code { get; init; } 
    
    /// <summary>
    /// Further details about the missing information.
    /// </summary>
    [IsoId("_j2rbcUgqEeaGKYpLDboHPQ")]
    [DisplayName("Additional Missing Information")]
    [IsoXmlTag("AddtlMssngInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalMissingInformation { get; init; } 
    
    
    #nullable disable
    
}
