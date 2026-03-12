// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Official identification of an organisation (legal entity) in a specific register.
/// </summary>
[IsoId("_QP1JwNp-Ed-ak6NoX_4Aeg_-158801686")]
[DisplayName("Organisation Identification")]
public partial record OrganisationIdentification5
{
    #nullable enable
    
    /// <summary>
    /// Name of the register of legal entities.
    /// </summary>
    [IsoId("_QP1Jwdp-Ed-ak6NoX_4Aeg_-1308997280")]
    [DisplayName("Registration Number")]
    [IsoXmlTag("RegnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text RegistrationNumber { get; init; } 
    
    /// <summary>
    /// Name of the register managed by a registration authority.
    /// </summary>
    [IsoId("_QP1Jwtp-Ed-ak6NoX_4Aeg_-1209035067")]
    [DisplayName("Register Name")]
    [IsoXmlTag("RegrNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RegisterName { get; init; } 
    
    
    #nullable disable
    
}
