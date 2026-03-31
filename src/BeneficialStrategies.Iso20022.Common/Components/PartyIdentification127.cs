// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity involved in an activity.
/// </summary>
[IsoId("_NveTwbPvEeelzbgsFa3sqQ")]
[DisplayName("Party Identification")]
public record PartyIdentification127
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_N_P1I7PvEeelzbgsFa3sqQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification44Choice_ Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_N_P1K7PvEeelzbgsFa3sqQ")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_N_P1LbPvEeelzbgsFa3sqQ")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification7? AlternateIdentification { get; init; }

    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    [IsoId("_N_P1NbPvEeelzbgsFa3sqQ")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTime2Choice_? ProcessingDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_N_P1PbPvEeelzbgsFa3sqQ")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_N_P1RbPvEeelzbgsFa3sqQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }
}
