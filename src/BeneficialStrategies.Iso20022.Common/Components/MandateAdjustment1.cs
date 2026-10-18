// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateAdjustment1"/>
[IsoId("_PJFAQGVQEeacpJ-gG9kyUQ")]
[DisplayName("Mandate Adjustment")]
public partial record MandateAdjustment1
{
    /// <inheritdoc cref="IMandateAdjustment1.DateAdjustmentRuleIndicator"/>
    [IsoId("_RgDh4GVUEeacpJ-gG9kyUQ")]
    [DisplayName("Date Adjustment Rule Indicator")]
    [IsoXmlTag("DtAdjstmntRuleInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator DateAdjustmentRuleIndicator { get; init; }

    /// <inheritdoc cref="IMandateAdjustment1.Category"/>
    [IsoId("_uNQtMGVUEeacpJ-gG9kyUQ")]
    [DisplayName("Category")]
    [IsoXmlTag("Ctgy")]
    public Frequency37Choice_? Category { get; init; }

    /// <inheritdoc cref="IMandateAdjustment1.Amount"/>
    [IsoId("_njXk5WVQEeacpJ-gG9kyUQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveCurrencyAndAmount? Amount { get; init; }

    /// <inheritdoc cref="IMandateAdjustment1.Rate"/>
    [IsoId("_OG1PAGoEEearR-CA7eRZXQ")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }
}
