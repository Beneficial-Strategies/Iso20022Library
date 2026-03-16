// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the balance for the billing services.
/// </summary>
[IsoId("_6SL4XZqlEeGSON8vddiWzQ_313331951")]
[DisplayName("Billing Balance")]
public record BillingBalance1
{
    /// <summary>
    /// Defines the type of balance.
    /// </summary>
    [IsoId("_6SL4XpqlEeGSON8vddiWzQ_1633836895")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BillingBalanceType1Choice_ Type { get; init; }

    /// <summary>
    /// Balance value.
    /// </summary>
    [IsoId("_6SVpUJqlEeGSON8vddiWzQ_-315097006")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required AmountAndDirection34 Value { get; init; }

    /// <summary>
    /// Identifies the currency type used to report the balance. This is not the ISO code.
    /// </summary>
    [IsoId("_6SVpUZqlEeGSON8vddiWzQ_69385719")]
    [DisplayName("Currency Type")]
    [IsoXmlTag("CcyTp")]
    public BillingCurrencyType1Code? CurrencyType { get; init; }
}
