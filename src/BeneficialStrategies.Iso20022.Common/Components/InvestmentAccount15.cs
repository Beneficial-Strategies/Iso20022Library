// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
[IsoId("_U9RwU9p-Ed-ak6NoX_4Aeg_-2850211")]
[DisplayName("Investment Account")]
public partial record InvestmentAccount15
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_U9RwVNp-Ed-ak6NoX_4Aeg_-2850192")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentification1? AccountIdentification { get; init; } 
    
    /// <summary>
    /// Account type.
    /// </summary>
    [IsoId("_U9RwVdp-Ed-ak6NoX_4Aeg_791350549")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType1? Type { get; init; } 
    
    
    #nullable disable
    
}
