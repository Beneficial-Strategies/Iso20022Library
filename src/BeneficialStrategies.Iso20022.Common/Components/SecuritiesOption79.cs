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
[IsoId("_N-tRJRuyEeyhRdHRjakS2w")]
[DisplayName("Securities Option")]
public partial record SecuritiesOption79
{
    #nullable enable
    
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    [IsoId("_OT3o0RuyEeyhRdHRjakS2w")]
    [DisplayName("Conditional Quantity")]
    [IsoXmlTag("CondlQty")]
    public FinancialInstrumentQuantity33Choice_? ConditionalQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    [IsoId("_OT3o2RuyEeyhRdHRjakS2w")]
    [DisplayName("Instructed Quantity")]
    [IsoXmlTag("InstdQty")]
    public required Quantity52Choice_ InstructedQuantity { get; init; } 
    
    /// <summary>
    /// Quantity of additional shares requested due to the difference of “round-up against payment” practice between the account servicer and the account holder (for instance for French dividend option).
    /// </summary>
    [IsoId("_OT3o2xuyEeyhRdHRjakS2w")]
    [DisplayName("Additional Round Up Quantity")]
    [IsoXmlTag("AddtlRndUpQty")]
    public FinancialInstrumentQuantity33Choice_? AdditionalRoundUpQuantity { get; init; } 
    
    
    #nullable disable
    
}
