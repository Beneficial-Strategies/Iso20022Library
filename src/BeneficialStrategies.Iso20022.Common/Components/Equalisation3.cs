// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Equalisation3.
/// </summary>
[IsoId("_paOzkRvfEe6BvtAMnhq3zw")]
[DisplayName("Equalisation3")]
public record Equalisation3
{
    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Equalisation Methodology Type.
    /// </summary>
    [DisplayName("Equalisation Methodology Type")]
    [IsoXmlTag("EqulstnMthdlgyTp")]
    public EqualisationMethodologyType2? EqualisationMethodologyType { get; init; }

    /// <summary>
    /// Gross Asset Value.
    /// </summary>
    [DisplayName("Gross Asset Value")]
    [IsoXmlTag("GrssAsstVal")]
    public ActiveOrHistoricCurrencyAndAmount? GrossAssetValue { get; init; }

    /// <summary>
    /// High Watermark.
    /// </summary>
    [DisplayName("High Watermark")]
    [IsoXmlTag("HghWtrmrk")]
    public ActiveOrHistoricCurrencyAndAmount? HighWatermark { get; init; }

    /// <summary>
    /// Rate.
    /// </summary>
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public IsoPercentageRate? Rate { get; init; }
}
