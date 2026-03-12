// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous way to identify a person.
/// </summary>
[IsoId("_V60Wp9p-Ed-ak6NoX_4Aeg_2101696687")]
[DisplayName("Person Identification")]
public partial record PersonIdentification4
{
    #nullable enable
    
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    [IsoId("_V60WqNp-Ed-ak6NoX_4Aeg_2101697014")]
    [DisplayName("Other Identification")]
    [IsoXmlTag("OthrId")]
    public required RestrictedIdentification2 OtherIdentification { get; init; } 
    
    
    #nullable disable
    
}
