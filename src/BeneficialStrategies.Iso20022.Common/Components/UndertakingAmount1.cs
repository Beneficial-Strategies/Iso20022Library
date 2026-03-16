// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an amount.
/// </summary>
[IsoId("_94wDmHltEeG7BsjMvd1mEw_-848178472")]
[DisplayName("Undertaking Amount")]
public record UndertakingAmount1
{
    /// <summary>
    /// Amount and currency of the undertaking.
    /// </summary>
    [IsoId("_945NgHltEeG7BsjMvd1mEw_-1186189572")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Percentage by which the amount claimed under the undertaking may be more than the undertaking amount.
    /// </summary>
    [IsoId("_945NgXltEeG7BsjMvd1mEw_537164761")]
    [DisplayName("Plus Tolerance")]
    [IsoXmlTag("PlusTlrnce")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PlusTolerance { get; init; }

    /// <summary>
    /// Additional information concerning the undertaking amount.
    /// </summary>
    [IsoId("_945NgnltEeG7BsjMvd1mEw_1114633018")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
}
