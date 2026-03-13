// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the type and amount of the cash reinvestment in a given currency and on the cash reinvestment rate.
/// </summary>
[IsoId("_ANAEgI67EeaxxtxaoOwzAg")]
[DisplayName("Cash Reuse Data")]
public partial record CashReuseData1
{
    #nullable enable
    
    /// <summary>
    /// Provides details on the type and amount of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_P73YgJLiEeelrYORFsXWZg")]
    [DisplayName("Reinvested Cash")]
    [IsoXmlTag("RinvstdCsh")]
    public ValueList<ReinvestedCashTypeAndAmount1> ReinvestedCash { get; init; } = [];
    // ID for the above is _P73YgJLiEeelrYORFsXWZg
    
    /// <summary>
    /// Average interest rate received on cash collateral reinvestment by the lender for reinvestment of cash collateral.
    /// </summary>
    [IsoId("_AgOw8JLiEeelrYORFsXWZg")]
    [DisplayName("Cash Reinvestment Rate")]
    [IsoXmlTag("CshRinvstmtRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate CashReinvestmentRate { get; init; } 
    
    
    #nullable disable
    
}
