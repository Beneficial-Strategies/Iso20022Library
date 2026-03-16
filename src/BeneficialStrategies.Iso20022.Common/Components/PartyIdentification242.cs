// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_hpztoAGNEeutW5-TpeYJhA")]
[DisplayName("Party Identification")]
public record PartyIdentification242
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_3_f9QAGNEeutW5-TpeYJhA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification178Choice_ Identification { get; init; }

    /// <summary>
    /// Type of membership the collateral provider holds with the CCP.
    /// </summary>
    [IsoId("_EImdEAGOEeutW5-TpeYJhA")]
    [DisplayName("CCP Member Type")]
    [IsoXmlTag("CCPMmbTp")]
    public CCPMemberType1Code? CCPMemberType { get; init; }
}
