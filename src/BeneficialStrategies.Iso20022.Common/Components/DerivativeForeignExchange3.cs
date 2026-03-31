// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of non-financial instrument of type foreign exchange as underlying.
/// </summary>
[IsoId("_8LPcAXvyEeanCNPcMT7sSg")]
[DisplayName("Derivative Foreign Exchange")]
public record DerivativeForeignExchange3
{
    /// <summary>
    /// Type of the underlying currency.
    /// </summary>
    [IsoId("_8UQ1IXvyEeanCNPcMT7sSg")]
    [DisplayName("FX Type")]
    [IsoXmlTag("FxTp")]
    public AssetFXSubProductType1Code? FXType { get; init; }

    /// <summary>
    /// Underlying currency 2 of the currency pair (the currency 1 will be populated in the notional currency).
    /// </summary>
    [IsoId("_8UQ1I3vyEeanCNPcMT7sSg")]
    [DisplayName("Other Notional Currency")]
    [IsoXmlTag("OthrNtnlCcy")]
    public ActiveOrHistoricCurrencyCode? OtherNotionalCurrency { get; init; }
}
