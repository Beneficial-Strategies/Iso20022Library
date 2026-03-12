// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions to be filled in to obtain a valid power of attorney.
/// </summary>
[IsoId("_T5CFEtp-Ed-ak6NoX_4Aeg_-1322861866")]
[DisplayName("Power Of Attorney Requirements")]
public partial record PowerOfAttorneyRequirements2
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the power of attorney needs to be validated by some authority.
    /// </summary>
    [IsoId("_T5CFE9p-Ed-ak6NoX_4Aeg_-1322861864")]
    [DisplayName("Legal Requirement")]
    [IsoXmlTag("LglRqrmnt")]
    [MinLength(0)]
    [MaxLength(4)]
    public SimpleValueList<PowerOfAttorneyLegalisation1Code> LegalRequirement { get; init; } = new SimpleValueList<PowerOfAttorneyLegalisation1Code>(){};
    
    /// <summary>
    /// Specifies the documents needed to obtain a valid power of attorney.
    /// </summary>
    [IsoId("_T5CFFNp-Ed-ak6NoX_4Aeg_-1322861849")]
    [DisplayName("Other Documentation")]
    [IsoXmlTag("OthrDcmnttn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? OtherDocumentation { get; init; } 
    
    
    #nullable disable
    
}
