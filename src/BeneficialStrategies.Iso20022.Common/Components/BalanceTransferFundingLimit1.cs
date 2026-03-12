// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Maximum value that the new bank will pay to the old bank when the closing balance on the old bank is negative.
/// </summary>
[IsoId("_x14swQ2aEeSNWNtJlXOAhg")]
[DisplayName("Balance Transfer Funding Limit")]
public partial record BalanceTransferFundingLimit1
{
    #nullable enable
    
    /// <summary>
    /// Maximum value and related currency that can be sent by the new account servicer to the old account servicer in case of a negative closing balance.
    /// </summary>
    [IsoId("_354PgA2aEeSNWNtJlXOAhg")]
    [DisplayName("Currency Amount")]
    [IsoXmlTag("CcyAmt")]
    public required ActiveCurrencyAndAmount CurrencyAmount { get; init; } 
    
    
    #nullable disable
    
}
