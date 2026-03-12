// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the party name entity through the valid short and long names of the party within the system.
/// </summary>
[IsoId("_kmC6JO5NEeCisYr99QEiWA_763135469")]
[DisplayName("Party Name")]
public partial record PartyName2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the date from which the party name is valid.
    /// </summary>
    [IsoId("_kmMrIO5NEeCisYr99QEiWA_1819995905")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValidFrom { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_kmMrIe5NEeCisYr99QEiWA_-1396951053")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; } 
    
    /// <summary>
    /// Specifies the short name of the organisation.
    /// </summary>
    [IsoId("_kmMrIu5NEeCisYr99QEiWA_-1408049830")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    
    #nullable disable
    
}
