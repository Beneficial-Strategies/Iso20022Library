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
[IsoId("_2cxO4NonEeCWg-hsBVGrDA_1433936569")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount83
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_2c6_4NonEeCWg-hsBVGrDA_1320097503")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification70Choice_ Identification { get; init; }

    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_2c6_4donEeCWg-hsBVGrDA_436864216")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_2c6_4tonEeCWg-hsBVGrDA_-560208137")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification2Choice_? CashAccount { get; init; }

    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_2c6_49onEeCWg-hsBVGrDA_-1557280490")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    [IsoId("_2c6_5NonEeCWg-hsBVGrDA_1740614453")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }

    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_2c6_5donEeCWg-hsBVGrDA_743542100")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification6? AlternateIdentification { get; init; }
}
