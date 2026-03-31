// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
[IsoId("_5nIER5NLEeWGlc8L7oPDIg")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount135
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_5nIES5NLEeWGlc8L7oPDIg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification104Choice_? Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_5nIEU5NLEeWGlc8L7oPDIg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_5nIEVZNLEeWGlc8L7oPDIg")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification9? AlternateIdentification { get; init; }

    /// <summary>
    /// Nationality of the investor or country of incorporation (for a company).
    /// </summary>
    [IsoId("_5nIEXZNLEeWGlc8L7oPDIg")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public CountryCode? Nationality { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_5nIEZZNLEeWGlc8L7oPDIg")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_5nIEbZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    [IsoId("_5nIEdZNLEeWGlc8L7oPDIg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation3? AdditionalInformation { get; init; }
}
