// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person, or a non-financial institution.
/// </summary>
[IsoId("_Pb-D5Np-Ed-ak6NoX_4Aeg_196982310")]
[DisplayName("Party Identification And Contact Information")]
public partial record PartyIdentificationAndContactInformation1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_Pb-D5dp-Ed-ak6NoX_4Aeg_-41534987")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification8 PartyIdentification { get; init; } 
    
    /// <summary>
    /// Information needed to contact a physical person related to the party, such as name, phone number, email address.
    /// </summary>
    [IsoId("_Pb-D5tp-Ed-ak6NoX_4Aeg_975951300")]
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactIdentification1? ContactInformation { get; init; } 
    
    
    #nullable disable
    
}
