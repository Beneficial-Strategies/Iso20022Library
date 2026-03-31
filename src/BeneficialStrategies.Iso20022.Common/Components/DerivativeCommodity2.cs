// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the details of a commodity derivative.
/// </summary>
[IsoId("_e-bjmXvyEeanCNPcMT7sSg")]
[DisplayName("Derivative Commodity")]
public record DerivativeCommodity2
{
    /// <summary>
    /// Commodity product attributes.
    /// </summary>
    [IsoId("_fHZ5YXvyEeanCNPcMT7sSg")]
    [DisplayName("Product")]
    [IsoXmlTag("Pdct")]
    public required AssetClassCommodity3Choice_ Product { get; init; }

    /// <summary>
    /// Transaction type as specified by the trading venue.
    /// </summary>
    [IsoId("_fHZ5Y3vyEeanCNPcMT7sSg")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public AssetClassTransactionType1Code? TransactionType { get; init; }

    /// <summary>
    /// Final price type as specified by the trading venue.
    /// </summary>
    [IsoId("_fHZ5ZXvyEeanCNPcMT7sSg")]
    [DisplayName("Final Price Type")]
    [IsoXmlTag("FnlPricTp")]
    public AssetPriceType1Code? FinalPriceType { get; init; }
}
