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
[IsoId("_Rpl8ceaPEd-q8fx_Zl_34A")]
[DisplayName("Party Identification")]
public record PartyIdentification48
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_RpvtYeaPEd-q8fx_Zl_34A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification44Choice_ Identification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_RpvtY-aPEd-q8fx_Zl_34A")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification2? AlternateIdentification { get; init; }

    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    [IsoId("_RpvtZeaPEd-q8fx_Zl_34A")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTimeChoice_? ProcessingDate { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_RpvtZ-aPEd-q8fx_Zl_34A")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_RpvtaeaPEd-q8fx_Zl_34A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }
}
