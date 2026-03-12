// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a discrepancy of a demand.
/// </summary>
[IsoId("_-BiMJnltEeG7BsjMvd1mEw_711014268")]
[DisplayName("Discrepancy")]
public partial record Discrepancy1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the discrepancy.
    /// </summary>
    [IsoId("_-BiMJ3ltEeG7BsjMvd1mEw_170785768")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Description of the discrepancy.
    /// </summary>
    [IsoId("_-BiMKXltEeG7BsjMvd1mEw_-2015726895")]
    [DisplayName("Narrative")]
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public required IsoMax20000Text Narrative { get; init; } 
    
    
    #nullable disable
    
}
