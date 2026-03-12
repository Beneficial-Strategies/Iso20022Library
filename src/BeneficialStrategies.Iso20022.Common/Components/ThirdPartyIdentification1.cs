// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the third party.
/// </summary>
[IsoId("_iumBkPQ-EeqAradXpAelDQ")]
[DisplayName("Third Party Identification")]
public partial record ThirdPartyIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Role played by the third party.
    /// </summary>
    [IsoId("_q9sxAPQ-EeqAradXpAelDQ")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public required PartyRole3Code Role { get; init; } 
    
    /// <summary>
    /// Identification of the third party legal entity.
    /// </summary>
    [IsoId("_xOpKoPQ-EeqAradXpAelDQ")]
    [DisplayName("Legal Person Identification")]
    [IsoXmlTag("LglPrsnId")]
    public PartyIdentification221? LegalPersonIdentification { get; init; } 
    
    
    #nullable disable
    
}
