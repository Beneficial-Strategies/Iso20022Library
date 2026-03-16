// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed Quantity Format16.
/// </summary>
[IsoId("_SJ9r8Zz2Ee-wlaN-gaj0FQ")]
[DisplayName("Signed Quantity Format16")]
public partial record SignedQuantityFormat16
{
    #nullable enable

    /// <summary>
    /// Quantity.
    /// </summary>
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity36Choice_ Quantity { get; init; } 

    /// <summary>
    /// Short Long Position.
    /// </summary>
    [DisplayName("Short Long Position")]
    [IsoXmlTag("ShrtLngPos")]
    public required ShortLong1Code ShortLongPosition { get; init; } 

    
    #nullable disable
    
}
