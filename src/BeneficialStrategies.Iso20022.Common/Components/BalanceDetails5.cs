// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance related details for a portfolio.
/// </summary>
[IsoId("_m9_jw_NBEeCuA5Tr22BnwA_-1587495854")]
[DisplayName("Balance Details")]
public record BalanceDetails5
{
    /// <summary>
    /// Balance type.
    /// </summary>
    [IsoId("_m9_jxPNBEeCuA5Tr22BnwA_-509912192")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BalanceType6Choice_ Type { get; init; }

    /// <summary>
    /// Unrealised gain or loss.
    /// </summary>
    [IsoId("_m9_jxfNBEeCuA5Tr22BnwA_1710399089")]
    [DisplayName("Unrealised")]
    [IsoXmlTag("Urlsd")]
    public Unrealised1Code? Unrealised { get; init; }

    /// <summary>
    /// Balance amount.
    /// </summary>
    [IsoId("_m-ItsPNBEeCuA5Tr22BnwA_944599101")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection31 Amount { get; init; }

    /// <summary>
    /// Detailed balance information.
    /// </summary>
    [IsoId("_m-ItsfNBEeCuA5Tr22BnwA_1949015826")]
    [DisplayName("Detailed Balance")]
    [IsoXmlTag("DtldBal")]
    public ValueList<BalanceDetails6> DetailedBalance { get; init; } = [];
}
