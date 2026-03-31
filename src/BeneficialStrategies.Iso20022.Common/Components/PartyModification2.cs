// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to the party.
/// </summary>
[IsoId("_9gwpd24-EeiU9cctagi5ow")]
[DisplayName("Party Modification")]
public record PartyModification2
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_9s0vcW4-EeiU9cctagi5ow")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_9s0vc24-EeiU9cctagi5ow")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification137 PartyIdentification { get; init; }
}
