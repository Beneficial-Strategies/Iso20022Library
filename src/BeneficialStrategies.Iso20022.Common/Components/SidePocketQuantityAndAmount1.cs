// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity of a security.
/// </summary>
[IsoId("_So3dsdp-Ed-ak6NoX_4Aeg_-562125146")]
[DisplayName("Side Pocket Quantity And Amount")]
public partial record SidePocketQuantityAndAmount1
{
    #nullable enable
    
    /// <summary>
    /// Total of quantity of units subscribed or redeemed in the lot or side pocket.
    /// </summary>
    [IsoId("_So3dstp-Ed-ak6NoX_4Aeg_-562125137")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public FinancialInstrumentQuantity1? UnitsNumber { get; init; } 
    
    /// <summary>
    /// Amount of money invested or redeemed into the lot or side pocket.
    /// </summary>
    [IsoId("_So3ds9p-Ed-ak6NoX_4Aeg_1851394913")]
    [DisplayName("Ordered Amount")]
    [IsoXmlTag("OrdrdAmt")]
    public ActiveCurrencyAndAmount? OrderedAmount { get; init; } 
    
    /// <summary>
    /// Percentage of the financial instrument quantity invested or redeemed in the lot or side pocket.
    /// </summary>
    [IsoId("_So3dtNp-Ed-ak6NoX_4Aeg_-562124806")]
    [DisplayName("Holdings Rate")]
    [IsoXmlTag("HldgsRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? HoldingsRate { get; init; } 
    
    
    #nullable disable
    
}
