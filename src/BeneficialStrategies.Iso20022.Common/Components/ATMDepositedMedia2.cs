// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Media item that are deposited.
/// </summary>
[IsoId("_udWnMK4DEeWL1uap3dNhCQ")]
[DisplayName("ATM Deposited Media")]
public record ATMDepositedMedia2
{
    /// <summary>
    /// Number of deposit media.
    /// </summary>
    [IsoId("_3qVUIK4DEeWL1uap3dNhCQ")]
    [DisplayName("Count")]
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Count { get; init; }

    /// <summary>
    /// Amount or denomination of one media item, if the media type is valued or entered by the customer.
    /// </summary>
    [IsoId("_82-_MK4DEeWL1uap3dNhCQ")]
    [DisplayName("Unit Value")]
    [IsoXmlTag("UnitVal")]
    public ImpliedCurrencyAndAmount? UnitValue { get; init; }

    /// <summary>
    /// Currency of media items, if valued and different from base currency.
    /// </summary>
    [IsoId("_BW11sK4EEeWL1uap3dNhCQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Format of the check code line.
    /// </summary>
    [IsoId("_GV2tYK4EEeWL1uap3dNhCQ")]
    [DisplayName("Code Line Format")]
    [IsoXmlTag("CdLineFrmt")]
    public CheckCodeLine1Code? CodeLineFormat { get; init; }

    /// <summary>
    /// Check code line.
    /// </summary>
    [IsoId("_reFkQK4EEeWL1uap3dNhCQ")]
    [DisplayName("Code Line")]
    [IsoXmlTag("CdLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CodeLine { get; init; }

    /// <summary>
    /// Check amount scanned by the check reader.
    /// </summary>
    [IsoId("_xGiagK4EEeWL1uap3dNhCQ")]
    [DisplayName("Scanned Value")]
    [IsoXmlTag("ScnndVal")]
    public ImpliedCurrencyAndAmount? ScannedValue { get; init; }

    /// <summary>
    /// Percentage of the confidence in the check amount.
    /// </summary>
    [IsoId("_1aimUK4EEeWL1uap3dNhCQ")]
    [DisplayName("Confidence Level")]
    [IsoXmlTag("CnfdncLvl")]
    [IsoSimpleType(IsoSimpleType.Percentage)]
    public IsoPercentage? ConfidenceLevel { get; init; }
}
