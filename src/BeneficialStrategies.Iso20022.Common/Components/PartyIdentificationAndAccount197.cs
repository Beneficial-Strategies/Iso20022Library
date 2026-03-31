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
[IsoId("_hk6F8SqGEeyR9JrVGfaMKw")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount197
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_h9fk5SqGEeyR9JrVGfaMKw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification120Choice_? Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_h9fk7SqGEeyR9JrVGfaMKw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_h9fk7yqGEeyR9JrVGfaMKw")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; }

    /// <summary>
    /// Nationality of the investor or country of incorporation (for a company).
    /// </summary>
    [IsoId("_h9fk9yqGEeyR9JrVGfaMKw")]
    [DisplayName("Nationality")]
    [IsoXmlTag("Ntlty")]
    public CountryCode? Nationality { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_h9fk_yqGEeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_eLpq8SqGEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_h9flByqGEeyR9JrVGfaMKw")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    [IsoId("_h9flDyqGEeyR9JrVGfaMKw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }
}
