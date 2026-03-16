// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_m87xoTDtEeO9waS4ina8CA")]
[DisplayName("Detailed Amount")]
public record DetailedAmount6
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_nLgZITDtEeO9waS4ina8CA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Date and time of the payment.
    /// </summary>
    [IsoId("_40ZicDDtEeO9waS4ina8CA")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateTime { get; init; }

    /// <summary>
    /// Card data entry mode for the related payment.
    /// </summary>
    [IsoId("_BnqH0DDuEeO9waS4ina8CA")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading1Code? CardDataEntryMode { get; init; }

    /// <summary>
    /// Data of an integrated circuit card application for the related payment.
    /// </summary>
    [IsoId("_JegvUDDuEeO9waS4ina8CA")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; }

    /// <summary>
    /// Short description of the amount to display or print.
    /// </summary>
    [IsoId("_nLgZIzDtEeO9waS4ina8CA")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Label { get; init; }
}
