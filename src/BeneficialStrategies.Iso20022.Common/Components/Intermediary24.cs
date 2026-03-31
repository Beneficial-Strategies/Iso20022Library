// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services to investors relating to financial products.
/// </summary>
[IsoId("_bNNI4RUGEeOIaq8KyCdIDQ")]
[DisplayName("Intermediary")]
public record Intermediary24
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_br2MtRUGEeOIaq8KyCdIDQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification4Choice_ Identification { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_br2MtxUGEeOIaq8KyCdIDQ")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account2? Account { get; init; }

    /// <summary>
    /// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
    /// </summary>
    [IsoId("_br2MuRUGEeOIaq8KyCdIDQ")]
    [DisplayName("Waived Trailer Commission Indicator")]
    [IsoXmlTag("WvdTrlrComssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WaivedTrailerCommissionIndicator { get; init; }

    /// <summary>
    /// Role or function performed by the intermediary.
    /// </summary>
    [IsoId("_xVM2kBUNEeOIaq8KyCdIDQ")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public PartyRole2Choice_? Role { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_br2MvxUGEeOIaq8KyCdIDQ")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_br2MwRUGEeOIaq8KyCdIDQ")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_br2MwxUGEeOIaq8KyCdIDQ")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress4? NameAndAddress { get; init; }
}
