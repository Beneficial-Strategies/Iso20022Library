// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for an account.
/// </summary>
[IsoId("_ydNSS5lcEeeE1Ya-LgRsuQ")]
[DisplayName("Cash Account Search Criteria")]
public record CashAccountSearchCriteria6
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_ylymhZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public AccountIdentificationSearchCriteria2Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// Specifies the nature, or use, of the cash account.
    /// </summary>
    [IsoId("_ylymh5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CashAccountType2Choice_? Type { get; init; }

    /// <summary>
    /// Specifies the currency of the cash account.
    /// </summary>
    [IsoId("_ylymiZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Balance of the account which is being queried.
    /// </summary>
    [IsoId("_ylymi5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public CashBalance9? Balance { get; init; }

    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_ylymjZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification125? AccountOwner { get; init; }

    /// <summary>
    /// Servicer of the account which is being queried.
    /// </summary>
    [IsoId("_ylymj5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; }
}
