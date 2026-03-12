// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash account.
/// </summary>
[IsoId("_SP-cmtp-Ed-ak6NoX_4Aeg_1750528088")]
[DisplayName("Cash Account")]
public partial record CashAccount19
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_SQINkNp-Ed-ak6NoX_4Aeg_-1479988612")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_SQINkdp-Ed-ak6NoX_4Aeg_1853964902")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the cash account or the securities account from which the cash account is derived.
    /// </summary>
    [IsoId("_SQINktp-Ed-ak6NoX_4Aeg_1853964933")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification2Choice_ AccountIdentification { get; init; } 
    
    
    #nullable disable
    
}
