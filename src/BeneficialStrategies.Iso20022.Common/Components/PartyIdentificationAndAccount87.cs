// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_2dEw4NonEeCWg-hsBVGrDA_925435149")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount87
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_2dEw4donEeCWg-hsBVGrDA_811596083")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification70Choice_ Identification { get; init; }

    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_2dEw4tonEeCWg-hsBVGrDA_-1068709557")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    [IsoId("_2dEw49onEeCWg-hsBVGrDA_-2065781910")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }

    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_2dEw5NonEeCWg-hsBVGrDA_1232113033")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification6? AlternateIdentification { get; init; }
}
