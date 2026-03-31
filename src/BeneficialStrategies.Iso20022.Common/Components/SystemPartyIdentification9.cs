// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique and unambiguous identification of a party within a system.
/// </summary>
[IsoId("_x7Ud0RirEeiNm9ItaZcR2A")]
[DisplayName("System Party Identification")]
public record SystemPartyIdentification9
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_yN6psRirEeiNm9ItaZcR2A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification136 Identification { get; init; }

    /// <summary>
    /// Unique identification of the responsible party.
    /// </summary>
    [IsoId("_vUry8VhKEeih3fUfzR38Ig")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    public PartyIdentification136? ResponsiblePartyIdentification { get; init; }

    /// <summary>
    /// Starting date from which the identification is valid.
    /// </summary>
    [IsoId("_xkq4kVhKEeih3fUfzR38Ig")]
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidFrom { get; init; }
}
