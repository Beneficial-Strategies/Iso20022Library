// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio of the American or Global Depository Receipt(s) per ordinary share(s).
/// </summary>
[IsoId("_1hE44DL3EeKU9IrkkToqcw_-385014275")]
[DisplayName("Corporate Action Rate SD")]
public record CorporateActionRateSD2
{
    /// <summary>
    /// Receipts quantity (base) of the American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_1hE44TL3EeKU9IrkkToqcw_-599097563")]
    [DisplayName("Receipt Base Quantity")]
    [IsoXmlTag("RctBaseQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ReceiptBaseQuantity { get; init; }

    /// <summary>
    ///  Ordinary shares quantity of the American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_1hE44jL3EeKU9IrkkToqcw_1099881985")]
    [DisplayName("Ordinary Share")]
    [IsoXmlTag("OrdnryShr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? OrdinaryShare { get; init; }
}
