// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total amount of commissions related to a specific order.
/// </summary>
[IsoId("_RrxjX9p-Ed-ak6NoX_4Aeg_-940532207")]
[DisplayName("Total Commissions")]
public partial record TotalCommissions3
{
    #nullable enable
    
    /// <summary>
    /// Total value of the commissions for a specific order.
    /// </summary>
    [IsoId("_Rr6tQNp-Ed-ak6NoX_4Aeg_-940531964")]
    [DisplayName("Total Amount Of Commissions")]
    [IsoXmlTag("TtlAmtOfComssns")]
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCommissions { get; init; } 
    
    /// <summary>
    /// Information related to a specific commission.
    /// </summary>
    [IsoId("_Rr6tQdp-Ed-ak6NoX_4Aeg_-940531912")]
    [DisplayName("Commission Details")]
    [IsoXmlTag("ComssnDtls")]
    public ValueList<Commission10> CommissionDetails { get; init; } = [];
    // ID for the above is _Rr6tQdp-Ed-ak6NoX_4Aeg_-940531912
    
    
    #nullable disable
    
}
