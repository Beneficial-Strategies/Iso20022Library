// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates in which direction the intention is to transfer the ownership of a financial instrument.
/// </summary>
[IsoId("_S4XSQNp-Ed-ak6NoX_4Aeg_2090952843")]
[DisplayName("Order Side")]
public partial record OrderSide1
{
    #nullable enable
    
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_S4XSQdp-Ed-ak6NoX_4Aeg_2133432264")]
    [DisplayName("Side")]
    [IsoXmlTag("Sd")]
    public Side1Code? Side { get; init; } 
    
    /// <summary>
    /// Indicates whether the status request is applicable for all orders.|Yes = all orders|No = status for orders matching certain criteria further specified in this message.
    /// </summary>
    [IsoId("_S4XSQtp-Ed-ak6NoX_4Aeg_-2032239627")]
    [DisplayName("All Orders Indicator")]
    [IsoXmlTag("AllOrdrsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AllOrdersIndicator { get; init; } 
    
    
    #nullable disable
    
}
