// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of change to party.
/// </summary>
[IsoId("_XGV88A4lEeK3IMoVvcTkkg")]
[DisplayName("Party Modification")]
public record PartyModification1
{
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    [IsoId("_gKCLAA4lEeK3IMoVvcTkkg")]
    [DisplayName("Modification Code")]
    [IsoXmlTag("ModCd")]
    public Modification1Code? ModificationCode { get; init; }

    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_qT5-AA4lEeK3IMoVvcTkkg")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification40 PartyIdentification { get; init; }
}
