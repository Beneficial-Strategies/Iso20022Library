// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fix of the penultimate accrual date of the transaction to the final (repurchase) date. Crystallizing the penultimate fixing into a fixed rate for the final business day. This will allow for parties to send timely settlement instructions for the repurchase leg of the transaction. Default value is 1 day.
/// </summary>
[IsoId("_SBqscOhlEeqspItL-MF5VQ")]
[DisplayName("Crystallisation Day")]
public record CrystallisationDay1
{
    /// <summary>
    /// Fix of the penultimate accrual date of the transaction to the final (repurchase) date. Crystallizing the penultimate fixing into a fixed rate for the final business day. This will allow for parties to send timely settlement instructions for the repurchase leg of the transaction. Default value is 1 day. If not 1 then crystallization period must be used.
    /// </summary>
    [IsoId("_bB3hoehlEeqspItL-MF5VQ")]
    [DisplayName("Day")]
    [IsoXmlTag("Day")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Day { get; init; }

    /// <summary>
    /// Number of days prior to the accrual date of the transaction to the final (repurchase) date.
    /// </summary>
    [IsoId("_gxCq8ehlEeqspItL-MF5VQ")]
    [DisplayName("Period")]
    [IsoXmlTag("Prd")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? Period { get; init; }
}
