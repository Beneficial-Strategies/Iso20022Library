// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment token information.
/// </summary>
[IsoId("_LTwEMWkiEeSTIuB9A-QJ6g")]
[DisplayName("Card Payment Token")]
public record CardPaymentToken2
{
    /// <summary>
    /// Additional token payment information.
    /// </summary>
    [IsoId("_8o4ssGtaEeSKOvNNYJQdoQ")]
    [DisplayName("Token Characteristic")]
    [IsoXmlTag("TknChrtc")]
    public SimpleValueList<IsoMax35Text> TokenCharacteristic { get; init; } = [];

    /// <summary>
    /// Level of confidence resulting of the identification and authentication of the cardholder performed and the entity that performed it.
    /// </summary>
    [IsoId("_SZewwGkiEeSTIuB9A-QJ6g")]
    [DisplayName("Token Assurance Level")]
    [IsoXmlTag("TknAssrncLvl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TokenAssuranceLevel { get; init; }
}
