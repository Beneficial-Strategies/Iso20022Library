// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction summmary details.
/// </summary>
[IsoId("_NFLDgBt9Eeaiht5D4a9WSA")]
[DisplayName("Queue Transaction")]
public partial record QueueTransaction1
{
    #nullable enable
    
    /// <summary>
    /// Account owner identification such as BIC.
    /// </summary>
    [IsoId("_XTgfwBt9Eeaiht5D4a9WSA")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public required FinancialInstitutionIdentification8 AccountOwner { get; init; } 
    
    /// <summary>
    /// Identification of the account such as IBAN or local identifier.
    /// </summary>
    [IsoId("_YXEOgBt9Eeaiht5D4a9WSA")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public required AccountIdentification4Choice_ Account { get; init; } 
    
    /// <summary>
    /// Number of transaction per counterparty.
    /// </summary>
    [IsoId("_aF5H0Bt9Eeaiht5D4a9WSA")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfTransactions { get; init; } 
    
    /// <summary>
    /// Aggregated amount of the transactions per counterparty.
    /// </summary>
    [IsoId("_bnonYBt9Eeaiht5D4a9WSA")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public required ActiveCurrencyAndAmount TotalAmount { get; init; } 
    
    
    #nullable disable
    
}
