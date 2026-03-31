// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party and its role.
/// </summary>
[IsoId("_n_UgEZTJEemqYPWMBuVawg")]
[DisplayName("Intermediary")]
public record Intermediary47
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_oTjqs5TJEemqYPWMBuVawg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification125Choice_ Identification { get; init; }

    /// <summary>
    /// Identification of the party with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_oTjqtZTJEemqYPWMBuVawg")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_oTjqt5TJEemqYPWMBuVawg")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account32? Account { get; init; }
}
