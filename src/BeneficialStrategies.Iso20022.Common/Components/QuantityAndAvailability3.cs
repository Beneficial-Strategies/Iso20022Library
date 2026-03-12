// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_ulaTMSp8EeyR9JrVGfaMKw")]
[DisplayName("Quantity And Availability")]
public partial record QuantityAndAvailability3
{
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_u9HBgSp8EeyR9JrVGfaMKw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity33Choice_ Quantity { get; init; } 
    
    /// <summary>
    /// Indicates whether the quantity of securities on the sub-balance is available.
    /// </summary>
    [IsoId("_u9HBgyp8EeyR9JrVGfaMKw")]
    [DisplayName("Availability Indicator")]
    [IsoXmlTag("AvlbtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AvailabilityIndicator { get; init; } 
    
    
    #nullable disable
    
}
