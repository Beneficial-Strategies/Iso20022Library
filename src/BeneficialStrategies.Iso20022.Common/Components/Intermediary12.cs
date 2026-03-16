// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party that provides services relating to financial products to investors, eg, advice on products and placement of orders for the investment fund.
/// </summary>
[IsoId("_QOyn9Np-Ed-ak6NoX_4Aeg_113093308")]
[DisplayName("Intermediary")]
public record Intermediary12
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_QOyn9dp-Ed-ak6NoX_4Aeg_114014789")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification4Choice_ Identification { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_QOyn9tp-Ed-ak6NoX_4Aeg_114015468")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account2? Account { get; init; }

    /// <summary>
    /// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
    /// </summary>
    [IsoId("_QOyn99p-Ed-ak6NoX_4Aeg_114015503")]
    [DisplayName("Waived Trailer Commission Indicator")]
    [IsoXmlTag("WvdTrlrComssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? WaivedTrailerCommissionIndicator { get; init; }

    /// <summary>
    /// The role or function performed by an intermediary in a given situation.
    /// </summary>
    [IsoId("_QOyn-Np-Ed-ak6NoX_4Aeg_114015780")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public InvestmentFundRole3Code? Role { get; init; }

    /// <summary>
    /// The role or function performed by an intermediary in a given situation.
    /// </summary>
    [IsoId("_QOyn-dp-Ed-ak6NoX_4Aeg_114015840")]
    [DisplayName("Extended Role")]
    [IsoXmlTag("XtndedRole")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoExtended350Code? ExtendedRole { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QOyn-tp-Ed-ak6NoX_4Aeg_114016434")]
    [DisplayName("Primary Communication Address")]
    [IsoXmlTag("PmryComAdr")]
    public CommunicationAddress3? PrimaryCommunicationAddress { get; init; }

    /// <summary>
    /// Communication device number or electronic address used for communication.
    /// </summary>
    [IsoId("_QOyn-9p-Ed-ak6NoX_4Aeg_114016364")]
    [DisplayName("Secondary Communication Address")]
    [IsoXmlTag("ScndryComAdr")]
    public CommunicationAddress3? SecondaryCommunicationAddress { get; init; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QO7x4Np-Ed-ak6NoX_4Aeg_114016711")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress4? NameAndAddress { get; init; }
}
