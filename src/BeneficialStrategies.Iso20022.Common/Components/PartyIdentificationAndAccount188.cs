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
[IsoId("_SsHgXffWEeiNZp_PtLohLw")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount188
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_SsHgYffWEeiNZp_PtLohLw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification137Choice_ Identification { get; init; }

    /// <summary>
    /// Legal Entity Identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_SsHgaffWEeiNZp_PtLohLw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_SsHga_fWEeiNZp_PtLohLw")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification9? AlternateIdentification { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_SsHgc_fWEeiNZp_PtLohLw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount37? SafekeepingAccount { get; init; }

    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    [IsoId("_SsHge_fWEeiNZp_PtLohLw")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTime2Choice_? ProcessingDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_SsHgg_fWEeiNZp_PtLohLw")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_SsHgi_fWEeiNZp_PtLohLw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation3? AdditionalInformation { get; init; }
}
