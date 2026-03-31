// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the central counterparty clearing time.
/// </summary>
[IsoId("_jg-jkZQPEeiok48Eh9lW9Q")]
[DisplayName("Clearing Party And Time")]
public record ClearingPartyAndTime8
{
    /// <summary>
    /// In the case of a contract that has been cleared, the unique code for the CCP that has cleared the contract.
    /// </summary>
    [IsoId("_jtjnA5QPEeiok48Eh9lW9Q")]
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public OrganisationIdentification9Choice_? CCP { get; init; }

    /// <summary>
    /// Time and date when clearing took place.
    /// </summary>
    [IsoId("_jtjnBZQPEeiok48Eh9lW9Q")]
    [DisplayName("Clearing Date Time")]
    [IsoXmlTag("ClrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ClearingDateTime { get; init; }
}
