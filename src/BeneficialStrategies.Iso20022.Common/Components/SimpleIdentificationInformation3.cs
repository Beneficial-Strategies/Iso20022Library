// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a party identification or account identification.
/// </summary>
[IsoId("_WIiCitp-Ed-ak6NoX_4Aeg_-2033931767")]
[DisplayName("Simple Identification Information")]
public partial record SimpleIdentificationInformation3
{
    #nullable enable
    
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, eg, account identifier.
    /// </summary>
    [IsoId("_WIiCi9p-Ed-ak6NoX_4Aeg_-2033931765")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max34Text)]
    [StringLength(maximumLength: 34 ,MinimumLength = 1)]
    public required IsoMax34Text Identification { get; init; } 
    
    
    #nullable disable
    
}
