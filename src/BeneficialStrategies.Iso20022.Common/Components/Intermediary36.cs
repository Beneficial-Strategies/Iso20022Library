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
[IsoId("_Ma9zBSCBEeWhHbfCMWc1cw")]
[DisplayName("Intermediary")]
public record Intermediary36
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_M3JYsyCBEeWhHbfCMWc1cw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification72Choice_ Identification { get; init; }

    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_6BavMSCIEeWJd9HF2tO7BA")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_M3JYtSCBEeWhHbfCMWc1cw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account20? Account { get; init; }

    /// <summary>
    /// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
    /// </summary>
    [IsoId("_M3JYtyCBEeWhHbfCMWc1cw")]
    [DisplayName("Waived Trailer Commission Indicator")]
    [IsoXmlTag("WvdTrlrComssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WaivedTrailerCommissionIndicator { get; init; }

    /// <summary>
    /// Role or function performed by the intermediary.
    /// </summary>
    [IsoId("_M3JYuSCBEeWhHbfCMWc1cw")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public PartyRole2Choice_? Role { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_M3JYuyCBEeWhHbfCMWc1cw")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public ValueList<CommunicationAddress6> PrimaryCommunicationAddress { get; init; } = [];

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_M3JYvSCBEeWhHbfCMWc1cw")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public ValueList<CommunicationAddress6> SecondaryCommunicationAddress { get; init; } = [];

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_M3JYvyCBEeWhHbfCMWc1cw")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress4? NameAndAddress { get; init; }
}
