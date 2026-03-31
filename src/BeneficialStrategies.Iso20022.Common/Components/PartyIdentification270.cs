// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to identify a person or an organisation.
/// </summary>
[IsoId("_ArjoiTUDEe2tRf29bleifQ")]
[DisplayName("Party Identification")]
public record PartyIdentification270
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_BDF-wzUDEe2tRf29bleifQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification246Choice_ Identification { get; init; }

    /// <summary>
    /// Ancillary identification information about the party.
    /// </summary>
    [IsoId("_BDF-xTUDEe2tRf29bleifQ")]
    [DisplayName("Additional Identification Information")]
    [IsoXmlTag("AddtlIdInf")]
    public PartyAdditionalIdentification2Choice_? AdditionalIdentificationInformation { get; init; }
}
