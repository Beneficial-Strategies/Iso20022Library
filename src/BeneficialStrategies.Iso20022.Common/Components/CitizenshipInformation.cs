// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_QBhoB9p-Ed-ak6NoX_4Aeg_-1749124449")]
[DisplayName("Citizenship Information")]
public partial record CitizenshipInformation
{
    #nullable enable
    
    /// <summary>
    /// Specifies the country where a person was born or is legally accepted as belonging to the country.
    /// </summary>
    [IsoId("_QBhoCNp-Ed-ak6NoX_4Aeg_-1749124448")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public required NationalityCode Nationality { get; init; } 
    
    /// <summary>
    /// Indicates whether the person is a legal minor. It may depend on the nationality, the domicile country or the transaction in which the person is involved.
    /// </summary>
    [IsoId("_QBhoCdp-Ed-ak6NoX_4Aeg_-1749124447")]
    [DisplayName("Minor Indicator")]
    [IsoXmlTag("MnrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MinorIndicator { get; init; } 
    
    
    #nullable disable
    
}
