// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money debited or credited on the books of an account servicer.
/// </summary>
[IsoId("_WSOKB9p-Ed-ak6NoX_4Aeg_-1965842707")]
[DisplayName("Amount And Direction")]
public partial record AmountAndDirection19
{
    #nullable enable
    
    /// <summary>
    /// Amount of money that is debited or credited.
    /// </summary>
    [IsoId("_WSOKCNp-Ed-ak6NoX_4Aeg_334979883")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates if the amount is a debited or a credited.
    /// </summary>
    [IsoId("_WSOKCdp-Ed-ak6NoX_4Aeg_-1659164823")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebitCode? CreditDebit { get; init; } 
    
    
    #nullable disable
    
}
