// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_-IRJIXhhEeidzqjNEfehPg")]
[DisplayName("Contact Identification And Address")]
public record ContactIdentificationAndAddress2
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_-U5P4XhhEeidzqjNEfehPg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Role of the party in the payment.
    /// </summary>
    [IsoId("_-U5P43hhEeidzqjNEfehPg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public required PaymentRole1Choice_ Role { get; init; }

    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    [IsoId("_-U5P5XhhEeidzqjNEfehPg")]
    [DisplayName("Communication Address")]
    [IsoXmlTag("ComAdr")]
    public required CommunicationAddress10 CommunicationAddress { get; init; }
}
