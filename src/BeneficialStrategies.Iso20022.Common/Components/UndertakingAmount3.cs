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
[IsoId("_95MIcHltEeG7BsjMvd1mEw_-289979186")]
[DisplayName("Undertaking Amount")]
public record UndertakingAmount3
{
    /// <summary>
    /// Amount and currency of the demand.
    /// </summary>
    [IsoId("_95MIcXltEeG7BsjMvd1mEw_266577466")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Additional information concerning the demand amount.
    /// </summary>
    [IsoId("_95MIcnltEeG7BsjMvd1mEw_-83568800")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = [];
}
