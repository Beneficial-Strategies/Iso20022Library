// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
/// </summary>
[IsoId("_QO7x6tp-Ed-ak6NoX_4Aeg_-789866808")]
[DisplayName("Party Identification")]
public partial record PartyIdentification15
{
    #nullable enable
    
    /// <summary>
    /// Country in which the organisation is registered.
    /// </summary>
    [IsoId("_QO7x69p-Ed-ak6NoX_4Aeg_-479565158")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; } 
    
    /// <summary>
    /// Description of an organisation.
    /// </summary>
    [IsoId("_QO7x7Np-Ed-ak6NoX_4Aeg_-447243502")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    
    #nullable disable
    
}
