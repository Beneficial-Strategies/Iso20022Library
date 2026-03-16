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
[IsoId("_P8Cj2W49EeiU9cctagi5ow")]
[DisplayName("Cash Account Search Criteria")]
public record CashAccountSearchCriteria7
{
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_QHzu9W49EeiU9cctagi5ow")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> AccountIdentification { get; init; } =
        [];

    /// <summary>
    /// Specifies the nature, or use, of the cash account.
    /// </summary>
    [IsoId("_QHzu9249EeiU9cctagi5ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValueList<CashAccountType2Choice_> Type { get; init; } = [];

    /// <summary>
    /// Specifies the currency of the cash account.
    /// </summary>
    [IsoId("_QHzu-W49EeiU9cctagi5ow")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public SimpleValueList<ActiveOrHistoricCurrencyCode> Currency { get; init; } = [];

    /// <summary>
    /// Balance of the account which is being queried.
    /// </summary>
    [IsoId("_QHzu-249EeiU9cctagi5ow")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance12> Balance { get; init; } = [];

    /// <summary>
    /// Owner of the account which is being queried.
    /// </summary>
    [IsoId("_QHzu_W49EeiU9cctagi5ow")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification135? AccountOwner { get; init; }

    /// <summary>
    /// Servicer of the account which is being queried.
    /// </summary>
    [IsoId("_QHzu_249EeiU9cctagi5ow")]
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? AccountServicer { get; init; }
}
