// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limits and amounts not part of the transaction amount. Not included in reconciliation totals.
/// ISO 8583 bit 54
/// </summary>
[IsoId("_tqq6gZMkEeuleeHpFMMhmQ")]
[DisplayName("Additional Amounts")]
public record AdditionalAmounts3
{
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_tzLWQZMkEeuleeHpFMMhmQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ISO8583AmountTypeCode Type { get; init; }

    /// <summary>
    /// Other type of amount.
    /// </summary>
    [IsoId("_tzLWQ5MkEeuleeHpFMMhmQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Amount of one occurrence of the breakdown amount.
    /// </summary>
    [IsoId("_tzLWRZMkEeuleeHpFMMhmQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// Short description of the additional amount.
    /// </summary>
    [IsoId("_tzLWR5MkEeuleeHpFMMhmQ")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Description { get; init; }

    /// <summary>
    /// Additional data for the additional amount.
    /// </summary>
    [IsoId("_VuCqELJkEeuy99eCNqlQ3g")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
