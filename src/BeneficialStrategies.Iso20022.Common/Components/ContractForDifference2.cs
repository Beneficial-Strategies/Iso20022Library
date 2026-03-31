// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transparency calculation specific details on a contract for difference, spread betting derivatives.
/// </summary>
[IsoId("_MStLwWlQEeaLAKoEUNsD9g")]
[DisplayName("Contract For Difference")]
public record ContractForDifference2
{
    /// <summary>
    /// Underlying type of the contract for difference.
    /// </summary>
    [IsoId("_Mb3u0WlQEeaLAKoEUNsD9g")]
    [DisplayName("Underlying Type")]
    [IsoXmlTag("UndrlygTp")]
    public required UnderlyingContractForDifferenceType3Code UnderlyingType { get; init; }

    /// <summary>
    /// Currency 1 of the underlying currency pair.
    /// </summary>
    [IsoId("_Mb3u02lQEeaLAKoEUNsD9g")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy1")]
    public ActiveOrHistoricCurrencyCode? NotionalCurrency1 { get; init; }

    /// <summary>
    /// Currency 2 of the underlying currency pair.
    /// </summary>
    [IsoId("_Mb3u1WlQEeaLAKoEUNsD9g")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy2")]
    public ActiveOrHistoricCurrencyCode? NotionalCurrency2 { get; init; }
}
