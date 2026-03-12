// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Legally constituted organization specified for this party.
/// </summary>
[IsoId("_9DOo8dOdEeS75MhTUaTyUQ")]
[DisplayName("Legal Organisation")]
public partial record LegalOrganisation2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_9M5iUdOdEeS75MhTUaTyUQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; } 
    
    /// <summary>
    /// Specifies the short name of the organisation.
    /// </summary>
    [IsoId("_9M5iU9OdEeS75MhTUaTyUQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Name { get; init; } 
    
    /// <summary>
    /// Date when the organisation was established.
    /// </summary>
    [IsoId("_92q4EdOdEeS75MhTUaTyUQ")]
    [DisplayName("Establishment Date")]
    [IsoXmlTag("EstblishmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EstablishmentDate { get; init; } 
    
    /// <summary>
    /// Date when the organisation was registered.
    /// </summary>
    [IsoId("_C59Lw9OeEeS75MhTUaTyUQ")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; } 
    
    
    #nullable disable
    
}
