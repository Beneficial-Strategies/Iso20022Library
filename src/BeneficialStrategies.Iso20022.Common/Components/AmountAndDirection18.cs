// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
[IsoId("_WRd8Fdp-Ed-ak6NoX_4Aeg_1201831166")]
[DisplayName("Amount And Direction")]
public partial record AmountAndDirection18
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_WRd8Ftp-Ed-ak6NoX_4Aeg_-792313540")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    [IsoId("_WRd8F9p-Ed-ak6NoX_4Aeg_1508509050")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public required CreditDebitCode CreditDebit { get; init; } 
    
    
    #nullable disable
    
}
