// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Network Fee1.
/// </summary>
[IsoId("__8vqgIVwEe-Pv9KR9bv9IA")]
[DisplayName("Network Fee1")]
public partial record NetworkFee1
{
    #nullable enable

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 

    /// <summary>
    /// Network Fee Quantity.
    /// </summary>
    [DisplayName("Network Fee Quantity")]
    [IsoXmlTag("NtwkFeeQty")]
    public required IsoMax30DecimalNumber NetworkFeeQuantity { get; init; } 

    
    #nullable disable
    
}
