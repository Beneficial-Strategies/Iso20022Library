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
[IsoId("_SQINmNp-Ed-ak6NoX_4Aeg_-1249584584")]
[DisplayName("Cash Account")]
public partial record CashAccount18
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the value is a debit or credit.
    /// </summary>
    [IsoId("_SQR-kNp-Ed-ak6NoX_4Aeg_-965587415")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [IsoId("_SQR-kdp-Ed-ak6NoX_4Aeg_-1212642935")]
    [DisplayName("Account Owner Identification")]
    [IsoXmlTag("AcctOwnrId")]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the cash account or the securities account from which the cash account is derived.
    /// </summary>
    [IsoId("_SQR-ktp-Ed-ak6NoX_4Aeg_-1212642934")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public required AccountIdentification2Choice_ AccountIdentification { get; init; } 
    
    /// <summary>
    /// The cash balance type.
    /// </summary>
    [IsoId("_SQR-k9p-Ed-ak6NoX_4Aeg_-1823469392")]
    [DisplayName("Balance Type")]
    [IsoXmlTag("BalTp")]
    public CashBalanceType1FormatType? BalanceType { get; init; } 
    
    
    #nullable disable
    
}
