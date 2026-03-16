// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The OriginalAmountDetails contains all amount information in the acceptor currency code necessary to manage currency conversion in the cardholder currency code.
/// </summary>
[IsoId("_H_Dk4K_TEeaepNKtQMrGAQ")]
[DisplayName("Original Amount Details")]
public record OriginalAmountDetails1
{
    /// <summary>
    /// Actual amount to be converted.
    /// </summary>
    [IsoId("_eQjRAK_TEeaepNKtQMrGAQ")]
    [DisplayName("Actual Amount")]
    [IsoXmlTag("ActlAmt")]
    public ImpliedCurrencyAndAmount? ActualAmount { get; init; }

    /// <summary>
    /// Minimum amount for conversion (in case of range of amounts).
    /// </summary>
    [IsoId("_nGuAcK_TEeaepNKtQMrGAQ")]
    [DisplayName("Minimum Amount")]
    [IsoXmlTag("MinAmt")]
    public ImpliedCurrencyAndAmount? MinimumAmount { get; init; }

    /// <summary>
    /// Maximum amount for conversion (in case of range of amounts).
    /// </summary>
    [IsoId("_uH150K_TEeaepNKtQMrGAQ")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; }
}
