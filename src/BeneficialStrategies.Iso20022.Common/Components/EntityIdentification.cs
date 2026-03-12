// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a business entity, eg, corporate or financial institution.
/// </summary>
[IsoId("_WHybpNp-Ed-ak6NoX_4Aeg_1831804214")]
[DisplayName("Entity Identification")]
public partial record EntityIdentification
{
    #nullable enable
    
    /// <summary>
    /// Type of identification, eg, BIC or URI.
    /// </summary>
    [IsoId("_WHybpdp-Ed-ak6NoX_4Aeg_285566508")]
    [DisplayName("Type")]
    [IsoXmlTag("Type")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4Text Type { get; init; } 
    
    /// <summary>
    /// Actual identification of the entity.
    /// </summary>
    [IsoId("_WHybptp-Ed-ak6NoX_4Aeg_388076065")]
    [DisplayName("Entity Identifier")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public required IsoMax30Text EntityIdentifier { get; init; } 
    
    
    #nullable disable
    
}
