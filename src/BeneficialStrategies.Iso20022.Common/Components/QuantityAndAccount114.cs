// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Quantity And Account114.
/// </summary>
[IsoId("_v_xRW4oiEe-efPejSUAtLw")]
[DisplayName("Quantity And Account114")]
public partial record QuantityAndAccount114
{
    #nullable enable

    /// <summary>
    /// Cash Account.
    /// </summary>
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification9Choice_? CashAccount { get; init; } 

    /// <summary>
    /// Denomination Choice.
    /// </summary>
    [DisplayName("Denomination Choice")]
    [IsoXmlTag("DnmtnChc")]
    public IsoMax210Text? DenominationChoice { get; init; } 

    /// <summary>
    /// Quantity Breakdown.
    /// </summary>
    [DisplayName("Quantity Breakdown")]
    [IsoXmlTag("QtyBrkdwn")]
    public ValueList<QuantityBreakdown62> QuantityBreakdown { get; init; } = [];

    /// <summary>
    /// Safekeeping Place.
    /// </summary>
    [DisplayName("Safekeeping Place")]
    [IsoXmlTag("SfkpgPlc")]
    public SafeKeepingPlace5? SafekeepingPlace { get; init; } 

    /// <summary>
    /// Settlement Quantity.
    /// </summary>
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required FinancialInstrumentQuantity33Choice_ SettlementQuantity { get; init; } 

    
    #nullable disable
    
}
