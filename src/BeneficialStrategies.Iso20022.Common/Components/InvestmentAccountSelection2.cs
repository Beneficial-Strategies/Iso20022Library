// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between a unique account identification and a set of account selection criteria.
/// </summary>
[IsoId("_RRsPZ9p-Ed-ak6NoX_4Aeg_-1532088201")]
[DisplayName("Investment Account Selection")]
public partial record InvestmentAccountSelection2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_RRsPaNp-Ed-ak6NoX_4Aeg_-1532088182")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification1 AccountIdentification { get; init; } 
    
    /// <summary>
    /// Various investment account information used to select a specific account.
    /// </summary>
    [IsoId("_RR2AYNp-Ed-ak6NoX_4Aeg_-1532088147")]
    [DisplayName("Other Account Selection Data")]
    [IsoXmlTag("OthrAcctSelctnData")]
    public required InvestmentAccount29 OtherAccountSelectionData { get; init; } 
    
    
    #nullable disable
    
}
