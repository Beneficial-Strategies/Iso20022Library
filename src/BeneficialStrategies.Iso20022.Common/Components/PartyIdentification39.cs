// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification and additional identification Information on the party.
/// </summary>
[IsoId("_QP1Jw9p-Ed-ak6NoX_4Aeg_812892082")]
[DisplayName("Party Identification")]
public partial record PartyIdentification39
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_QP1JxNp-Ed-ak6NoX_4Aeg_-522561105")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification9Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Ancillary identification information about the party.
    /// </summary>
    [IsoId("_QP1Jxdp-Ed-ak6NoX_4Aeg_2116363711")]
    [DisplayName("Additional Identification Information")]
    [IsoXmlTag("AddtlIdInf")]
    public PartyAdditionalIdentification2Choice_? AdditionalIdentificationInformation { get; init; } 
    
    
    #nullable disable
    
}
