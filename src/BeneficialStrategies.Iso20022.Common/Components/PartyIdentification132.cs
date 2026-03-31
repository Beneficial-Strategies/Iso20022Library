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
[IsoId("_OevfoU3hEeidB49bWZiS0g")]
[DisplayName("Party Identification")]
public record PartyIdentification132
{
    /// <summary>
    /// Identification of the party expressed as a BIC.
    /// </summary>
    [IsoId("_RyP3w03hEeidB49bWZiS0g")]
    [DisplayName("Any BIC")]
    [IsoXmlTag("AnyBIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public IsoAnyBICDec2014Identifier? AnyBIC { get; init; }

    /// <summary>
    /// Choice of identifier for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
    /// </summary>
    [IsoId("_fA1Y8U3hEeidB49bWZiS0g")]
    [DisplayName("Clearing System Member Identification")]
    [IsoXmlTag("ClrSysMmbId")]
    public ClearingSystemMemberIdentification2Choice_? ClearingSystemMemberIdentification { get; init; }

    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_RyP3xU3hEeidB49bWZiS0g")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress5? NameAndAddress { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier, as assigned to the party using a proprietary identification scheme.
    /// </summary>
    [IsoId("_RyP3xE3hEeidB49bWZiS0g")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification1? ProprietaryIdentification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_OvOytU3hEeidB49bWZiS0g")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
