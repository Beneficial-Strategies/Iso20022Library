// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_PW59tdp-Ed-ak6NoX_4Aeg_-515475026")]
[DisplayName("Party And Signature")]
public record PartyAndSignature1
{
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_PW59ttp-Ed-ak6NoX_4Aeg_-1799527953")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification41 Party { get; init; }

    /// <summary>
    /// Signature of a party.
    /// </summary>
    [IsoId("_PW59t9p-Ed-ak6NoX_4Aeg_-1223443864")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public required ProprietaryData3 Signature { get; init; }
}
