// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the members of a system.
/// </summary>
[IsoId("_FD6i8ZlCEee-Zps0fZQaFQ")]
[DisplayName("Member")]
public record Member3
{
    /// <summary>
    /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, eg, returns or rejects.
    /// </summary>
    [IsoId("_FMsEcZlCEee-Zps0fZQaFQ")]
    [DisplayName("Member Return Address")]
    [IsoXmlTag("MmbRtrAdr")]
    public ValueList<MemberIdentification2Choice_> MemberReturnAddress { get; init; } = [];

    /// <summary>
    /// Person to be contacted in a given organisation.
    /// </summary>
    [IsoId("_FMsEc5lCEee-Zps0fZQaFQ")]
    [DisplayName("Contact Reference")]
    [IsoXmlTag("CtctRef")]
    public ValueList<ContactIdentificationAndAddress1> ContactReference { get; init; } = [];

    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    [IsoId("_FMsEdZlCEee-Zps0fZQaFQ")]
    [DisplayName("Communication Address")]
    [IsoXmlTag("ComAdr")]
    public CommunicationAddress8? CommunicationAddress { get; init; }
}
