// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the identification of a person.
/// </summary>
[IsoId("_KaECoDnlEeW7UoCHqpiMaQ")]
[DisplayName("Personal Information")]
public partial record PersonalInformation1
{
    #nullable enable
    
    /// <summary>
    /// Name of the father of the individual person.
    /// </summary>
    [IsoId("_ZTjmcDnlEeW7UoCHqpiMaQ")]
    [DisplayName("Name Of Father")]
    [IsoXmlTag("NmOfFthr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NameOfFather { get; init; } 
    
    /// <summary>
    /// Maiden (unmarried) name of the mother of the individual person.
    /// </summary>
    [IsoId("_ZTjmcTnlEeW7UoCHqpiMaQ")]
    [DisplayName("Maiden Name Of Mother")]
    [IsoXmlTag("MdnNmOfMthr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MaidenNameOfMother { get; init; } 
    
    /// <summary>
    /// Name of the partner of the individual person.
    /// </summary>
    [IsoId("_ZTjmcjnlEeW7UoCHqpiMaQ")]
    [DisplayName("Name Of Partner")]
    [IsoXmlTag("NmOfPrtnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? NameOfPartner { get; init; } 
    
    
    #nullable disable
    
}
