// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements that further identifies the type of local instruments being requested by the initiating party.
/// </summary>
[IsoId("_VyVJA9p-Ed-ak6NoX_4Aeg_-2089814377")]
[DisplayName("Local Instrument")]
public partial record LocalInstrument1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the local instrument published in an external local instrument code list - restricted to B2B or CORE within SEPA.
    /// </summary>
    [IsoId("_VyVJBNp-Ed-ak6NoX_4Aeg_-2089814375")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.RestrictedB2BCORECodeText)]
    public required IsoRestrictedB2BCORECodeText Code { get; init; } 
    
    
    #nullable disable
    
}
