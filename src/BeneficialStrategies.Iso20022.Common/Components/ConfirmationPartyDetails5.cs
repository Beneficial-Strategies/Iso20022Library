// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_AS2gANokEeC60axPepSq7g_2012095591")]
[DisplayName("Confirmation Party Details")]
public record ConfirmationPartyDetails5
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_ATARANokEeC60axPepSq7g_1898256525")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification32Choice_ Identification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_ATARAdokEeC60axPepSq7g_1015023238")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification5? AlternateIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_ATARAtokEeC60axPepSq7g_17950885")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_ATARA9okEeC60axPepSq7g_-979121468")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation5? AdditionalInformation { get; init; }

    /// <summary>
    /// Indicates whether the confirmation party is a member of the investor protection association required, eg, as per regulation.
    /// </summary>
    [IsoId("_ATJa8NokEeC60axPepSq7g_2077001085")]
    [DisplayName("Investor Protection Association Membership")]
    [IsoXmlTag("InvstrPrtcnAssoctnMmbsh")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InvestorProtectionAssociationMembership { get; init; }
}
