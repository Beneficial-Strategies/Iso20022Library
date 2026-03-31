// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details for the adjustment of the mandate.
/// </summary>
[IsoId("_PJFAQGVQEeacpJ-gG9kyUQ")]
[DisplayName("Mandate Adjustment")]
public record MandateAdjustment1
{
    /// <summary>
    /// Specifies whether an adjustment is to be applied on pre-agreed collection date or not.
    /// </summary>
    [IsoId("_RgDh4GVUEeacpJ-gG9kyUQ")]
    [DisplayName("Date Adjustment Rule Indicator")]
    [IsoXmlTag("DtAdjstmntRuleInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DateAdjustmentRuleIndicator { get; init; }

    /// <summary>
    /// Defines the category of adjustment.
    /// </summary>
    [IsoId("_uNQtMGVUEeacpJ-gG9kyUQ")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    public Frequency37Choice_? Category { get; init; }

    /// <summary>
    /// Pre-agreed amount to increase or decrease the mandate amount as justified per information in the category.
    /// </summary>
    [IsoId("_njXk5WVQEeacpJ-gG9kyUQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Pre-agreed increase or decrease rate that will be applied to the collection amount.
    /// </summary>
    [IsoId("_OG1PAGoEEearR-CA7eRZXQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }
}
