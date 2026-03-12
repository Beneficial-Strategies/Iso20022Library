// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the authorised tax paying party.
/// </summary>
[IsoId("_Pc3bx9p-Ed-ak6NoX_4Aeg_-197973580")]
[DisplayName("Tax Authorisation")]
public partial record TaxAuthorisation1
{
    #nullable enable
    
    /// <summary>
    /// Title or position of debtor or the debtor&apos;s authorised representative.
    /// </summary>
    [IsoId("_Pc3byNp-Ed-ak6NoX_4Aeg_-197973519")]
    [DisplayName("Title")]
    [IsoXmlTag("Titl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Title { get; init; } 
    
    /// <summary>
    /// Name of the debtor or the debtor&apos;s authorised representative.
    /// </summary>
    [IsoId("_PdBMwNp-Ed-ak6NoX_4Aeg_-197973549")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; } 
    
    
    #nullable disable
    
}
