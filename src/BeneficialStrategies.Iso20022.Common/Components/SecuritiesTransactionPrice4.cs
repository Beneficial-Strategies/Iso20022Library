// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price with notation.
/// </summary>
[IsoId("_tsWZ4f9iEea3W_f2lS_aiw")]
[DisplayName("Securities Transaction Price")]
public record SecuritiesTransactionPrice4
{
    /// <summary>
    /// Value of the price.
    /// </summary>
    [IsoId("_t14wY_9iEea3W_f2lS_aiw")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.LongFraction21DecimalNumber)]
    public IsoLongFraction21DecimalNumber? Value { get; init; }

    /// <summary>
    /// Notation of the price.
    /// </summary>
    [IsoId("_t14wZf9iEea3W_f2lS_aiw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }
}
