// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the first side of the transaction.
/// </summary>
[IsoId("_k2Zhy__9Eemefbt-QjTNnA")]
[DisplayName("Collateral Type")]
public record CollateralType14
{
    /// <summary>
    /// Data specific to securities and related fields used as a collateral.
    /// </summary>
    [IsoId("_k7YIYf_9Eemefbt-QjTNnA")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public ValueList<Security16> Security { get; init; } = [];

    /// <summary>
    /// Amount of funds provided as collateral for borrowing the securities or commodities.
    /// </summary>
    [IsoId("_k7YIY__9Eemefbt-QjTNnA")]
    [DisplayName("Cash")]
    [IsoXmlTag("Csh")]
    public ValueList<AmountHaircutMargin1> Cash { get; init; } = [];

    /// <summary>
    /// Data specific to commodities and related fields used as a collateral.
    /// </summary>
    [IsoId("_k7YIZf_9Eemefbt-QjTNnA")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public ValueList<Commodity20> Commodity { get; init; } = [];
}
