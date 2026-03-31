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
[IsoId("_kEyRFXSbEeiH1ZOt2UD8vQ")]
[DisplayName("Member")]
public record Member5
{
    /// <summary>
    /// Word by which something is called or known or the family name of a person.
    /// </summary>
    [IsoId("_kPQbsXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; }

    /// <summary>
    /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example returns or rejects.
    /// </summary>
    [IsoId("_kPQbs3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Return Address")]
    [IsoXmlTag("RtrAdr")]
    public ValueList<MemberIdentification3Choice_> ReturnAddress { get; init; } = [];

    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_kPQbtXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public ValueList<CashAccount38> Account { get; init; } = [];

    /// <summary>
    /// Nature of the relationship a member has with a system.
    /// </summary>
    [IsoId("_kPQbt3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public SystemMemberType1Choice_? Type { get; init; }

    /// <summary>
    /// Status of a member in a system, for example enabled or deleted.
    /// </summary>
    [IsoId("_kPQbuXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public SystemMemberStatus1Choice_? Status { get; init; }

    /// <summary>
    /// Person to be contacted in a given organisation.
    /// </summary>
    [IsoId("_kPQbu3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Contact Reference")]
    [IsoXmlTag("CtctRef")]
    public ValueList<ContactIdentificationAndAddress2> ContactReference { get; init; } = [];

    /// <summary>
    /// Number, or virtual address, used for communication.
    /// </summary>
    [IsoId("_kPQbvXSbEeiH1ZOt2UD8vQ")]
    [DisplayName("Communication Address")]
    [IsoXmlTag("ComAdr")]
    public CommunicationAddress10? CommunicationAddress { get; init; }
}
