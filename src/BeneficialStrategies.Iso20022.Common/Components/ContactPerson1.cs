// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains information about the contact responsible for the transaction identified in the message.
/// </summary>
[IsoId("_QDnStdp-Ed-ak6NoX_4Aeg_-2124213178")]
[DisplayName("Contact Person")]
public record ContactPerson1
{
    /// <summary>
    /// Provides additional information regarding the party, eg, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_QDnSttp-Ed-ak6NoX_4Aeg_946468932")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public required ContactIdentification4 ContactPerson { get; init; }

    /// <summary>
    /// Identification of the institution that the contact person represents.
    /// </summary>
    [IsoId("_QDnSt9p-Ed-ak6NoX_4Aeg_-2054025257")]
    [DisplayName("Institution Identification")]
    [IsoXmlTag("InstnId")]
    public PartyIdentification2Choice_? InstitutionIdentification { get; init; }
}
