// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on an account.
/// </summary>
[IsoId("_t-nrYXX4Eei3jO6riKEVXg")]
[DisplayName("Cash Account Return Criteria")]
public record CashAccountReturnCriteria5
{
    /// <summary>
    /// Indicates whether the account name is requested.
    /// </summary>
    [IsoId("_uIKB43X4Eei3jO6riKEVXg")]
    [DisplayName("Name Indicator")]
    [IsoXmlTag("NmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? NameIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account currency is requested.
    /// </summary>
    [IsoId("_uIKB5XX4Eei3jO6riKEVXg")]
    [DisplayName("Currency Indicator")]
    [IsoXmlTag("CcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CurrencyIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account type is requested.
    /// </summary>
    [IsoId("_uIKB53X4Eei3jO6riKEVXg")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TypeIndicator { get; init; }

    /// <summary>
    /// Indicates whether the multilateral limit is requested.
    /// </summary>
    [IsoId("_uIKB6XX4Eei3jO6riKEVXg")]
    [DisplayName("Multilateral Limit Indicator")]
    [IsoXmlTag("MulLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MultilateralLimitIndicator { get; init; }

    /// <summary>
    /// Defines the criteria used to report on a multilateral balance.
    /// </summary>
    [IsoId("_uIKB63X4Eei3jO6riKEVXg")]
    [DisplayName("Multilateral Balance Return Criteria")]
    [IsoXmlTag("MulBalRtrCrit")]
    public CashBalanceReturnCriteria2? MultilateralBalanceReturnCriteria { get; init; }

    /// <summary>
    /// Indicates whether the bilateral limit is requested.
    /// </summary>
    [IsoId("_uIKB7XX4Eei3jO6riKEVXg")]
    [DisplayName("Bilateral Limit Indicator")]
    [IsoXmlTag("BilLmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? BilateralLimitIndicator { get; init; }

    /// <summary>
    /// Defines the criteria used to report on a bilateral balance.
    /// </summary>
    [IsoId("_uIKB73X4Eei3jO6riKEVXg")]
    [DisplayName("Bilateral Balance Return Criteria")]
    [IsoXmlTag("BilBalRtrCrit")]
    public CashBalanceReturnCriteria2? BilateralBalanceReturnCriteria { get; init; }

    /// <summary>
    /// Indicates whether the account standing order is requested.
    /// </summary>
    [IsoId("_uIKB8XX4Eei3jO6riKEVXg")]
    [DisplayName("Standing Order Indicator")]
    [IsoXmlTag("StgOrdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StandingOrderIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account owner information is requested.
    /// </summary>
    [IsoId("_uIKB83X4Eei3jO6riKEVXg")]
    [DisplayName("Account Owner Indicator")]
    [IsoXmlTag("AcctOwnrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountOwnerIndicator { get; init; }

    /// <summary>
    /// Indicates whether the account servicer information is requested.
    /// </summary>
    [IsoId("_uIKB9XX4Eei3jO6riKEVXg")]
    [DisplayName("Account Servicer Indicator")]
    [IsoXmlTag("AcctSvcrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountServicerIndicator { get; init; }
}
