// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date of last revision.
/// </summary>
[IsoId("_RfGZQ9p-Ed-ak6NoX_4Aeg_-651747461")]
[DisplayName("Updated Date")]
public partial record UpdatedDate
{
    #nullable enable
    
    /// <summary>
    /// Date of last revision.
    /// </summary>
    [IsoId("_RfGZRNp-Ed-ak6NoX_4Aeg_-590794644")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate Date { get; init; } 
    
    
    #nullable disable
    
}
