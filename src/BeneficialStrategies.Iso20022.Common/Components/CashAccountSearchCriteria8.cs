// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash Account Search Criteria8.
/// </summary>
[IsoId("_6RRGmTEyEe6g-ffJsqGiSA")]
[DisplayName("Cash Account Search Criteria8")]
public record CashAccountSearchCriteria8
{
    /// <summary>
    /// Account Identification.
    /// </summary>
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public ValueList<AccountIdentificationSearchCriteria2Choice_> AccountIdentification { get; init; } =
        [];

    /// <summary>
    /// Account Owner.
    /// </summary>
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification272? AccountOwner { get; init; }

    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public BranchAndFinancialInstitutionIdentification8? AccountServicer { get; init; }

    /// <summary>
    /// Balance.
    /// </summary>
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ValueList<CashBalance14> Balance { get; init; } = [];

    /// <summary>
    /// Currency.
    /// </summary>
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ValueList<ActiveOrHistoricCurrencyCode> Currency { get; init; } = [];

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ValueList<CashAccountType2Choice_> Type { get; init; } = [];
}
