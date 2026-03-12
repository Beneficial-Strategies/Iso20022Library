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
[IsoId("_klmOM-5NEeCisYr99QEiWA_1401416164")]
[DisplayName("Party Name")]
public partial record PartyName1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the date from which the party name is valid.
    /// </summary>
    [IsoId("_klmONO5NEeCisYr99QEiWA_305623732")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValidFrom { get; init; } 
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_klv_MO5NEeCisYr99QEiWA_-2000389955")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Specifies the short name of the organisation.
    /// </summary>
    [IsoId("_klv_Me5NEeCisYr99QEiWA_284620483")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ShortName { get; init; } 
    
    
    #nullable disable
    
}
