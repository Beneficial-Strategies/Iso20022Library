// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of expected margin required by any of the parties of the margin calculation.
/// </summary>
[IsoId("_Ul4kANp-Ed-ak6NoX_4Aeg_836086296")]
[DisplayName("Margin Requirement")]
public partial record MarginRequirement1
{
    #nullable enable
    
    /// <summary>
    /// Amount of new margin that will be delivered to one party by the other party after rounding, threshold and minimum transfer amount are taken into account.
    /// </summary>
    [IsoId("_Ul4kAdp-Ed-ak6NoX_4Aeg_1961004215")]
    [DisplayName("Deliver Margin Amount")]
    [IsoXmlTag("DlvrMrgnAmt")]
    public ActiveCurrencyAndAmount? DeliverMarginAmount { get; init; } 
    
    /// <summary>
    /// Amount of new margin that will be recalled to one party from the other party after rounding, threshold and minimum transfer amount are taken into account.
    /// </summary>
    [IsoId("_Ul4kAtp-Ed-ak6NoX_4Aeg_-1890638845")]
    [DisplayName("Return Margin Amount")]
    [IsoXmlTag("RtrMrgnAmt")]
    public ActiveCurrencyAndAmount? ReturnMarginAmount { get; init; } 
    
    
    #nullable disable
    
}
