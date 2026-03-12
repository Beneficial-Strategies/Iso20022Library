// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio of the American or Global Depository Receipt(s) per ordinary share(s).
/// </summary>
[IsoId("_1hE44DL3EeKU9IrkkToqcw_-385014275")]
[DisplayName("Corporate Action Rate SD")]
public partial record CorporateActionRateSD2
{
    #nullable enable
    
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
    
    
    #nullable disable
    
}
