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
[IsoId("_ATJa8dokEeC60axPepSq7g_-1403872742")]
[DisplayName("Confirmation Party Details")]
public record ConfirmationPartyDetails4
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_ATJa8tokEeC60axPepSq7g_-1517711808")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification32Choice_ Identification { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ATJa89okEeC60axPepSq7g_1894022201")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount3? SafekeepingAccount { get; init; }

    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    [IsoId("_ATJa9NokEeC60axPepSq7g_896949848")]
    [DisplayName("Cash Details")]
    [IsoXmlTag("CshDtls")]
    public AccountIdentification3Choice_? CashDetails { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_ATJa9dokEeC60axPepSq7g_-100122505")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification5? AlternateIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_ATTL8NokEeC60axPepSq7g_548072577")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_ATTL8dokEeC60axPepSq7g_-448999776")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation5? AdditionalInformation { get; init; }
}
