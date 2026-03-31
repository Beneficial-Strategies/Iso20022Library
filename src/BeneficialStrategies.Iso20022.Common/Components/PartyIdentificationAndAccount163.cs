// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification and account of the party.
/// </summary>
[IsoId("_y_V6RbXEEeiTob_PrFFUxA")]
[DisplayName("Party Identification And Account")]
public record PartyIdentificationAndAccount163
{
    /// <summary>
    /// Identification of a party.
    /// </summary>
    [IsoId("_zRCuBbXEEeiTob_PrFFUxA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification120Choice_ Identification { get; init; }

    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    [IsoId("_zRCuDbXEEeiTob_PrFFUxA")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SafekeepingAccount { get; init; }

    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    [IsoId("_zRCuFbXEEeiTob_PrFFUxA")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_zRCuHbXEEeiTob_PrFFUxA")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification7> AlternateIdentification { get; init; } = [];
}
