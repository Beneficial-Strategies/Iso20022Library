// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms of the underlying transaction.
/// </summary>
[IsoId("_2ioGoVnKEeOQYsoJizpkVw")]
[DisplayName("Early Payments VAT")]
public record EarlyPaymentsVAT1
{
    /// <summary>
    /// Tax rate to be applied for early payment.
    /// </summary>
    [IsoId("__SA4oFnKEeOQYsoJizpkVw")]
    [DisplayName("Tax Rate")]
    [IsoXmlTag("TaxRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate TaxRate { get; init; }

    /// <summary>
    /// Type of tax applied.
    /// </summary>
    [IsoId("_FFf6MFnLEeOQYsoJizpkVw")]
    [DisplayName("Discount Tax Type")]
    [IsoXmlTag("DscntTaxTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4Text DiscountTaxType { get; init; }

    /// <summary>
    /// Early payment discount tax amount calculated using defined tax rate.
    /// </summary>
    [IsoId("_KOJPAFnLEeOQYsoJizpkVw")]
    [DisplayName("Discount Tax Amount")]
    [IsoXmlTag("DscntTaxAmt")]
    public required CurrencyAndAmount DiscountTaxAmount { get; init; }
}
