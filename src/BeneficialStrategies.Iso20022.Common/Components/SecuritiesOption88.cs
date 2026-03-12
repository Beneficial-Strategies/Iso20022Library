// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies securities quantities for corporate action instruction.
/// </summary>
[IsoId("_pizbZzi7Eeydid5dcNPKvg")]
[DisplayName("Securities Option")]
public partial record SecuritiesOption88
{
    #nullable enable
    
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    [IsoId("_pizbaTi7Eeydid5dcNPKvg")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity36Choice_? ConditionalQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    [IsoId("_pizbcTi7Eeydid5dcNPKvg")]
    [DisplayName("Instructed Quantity")]
    [IsoXmlTag("InstdQty")]
    public required Quantity55Choice_ InstructedQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of additional shares requested due to the difference of “round-up against payment” practice between the account servicer and the account holder (for instance for French dividend option).
    /// </summary>
    [IsoId("_pizbczi7Eeydid5dcNPKvg")]
    [DisplayName("Additional Round Up Quantity")]
    [IsoXmlTag("AddtlRndUpQty")]
    public FinancialInstrumentQuantity36Choice_? AdditionalRoundUpQuantity { get; init; } 
    
    
    #nullable disable
    
}
