// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the periods related to a corporate action option.
/// </summary>
[IsoId("_8yJU4atnEfCqjuqNaaNXgw")]
[DisplayName("Corporate Action Period18")]
public record CorporateActionPeriod18
{
    /// <summary>
    /// Period during which the price of a security is calculated.
    /// </summary>
    [IsoId("_8yJU4qtnEfCqjuqNaaNXgw")]
    [DisplayName("Price Calculation Period")]
    [IsoXmlTag("PricClctnPrd")]
    public Period12Choice_? PriceCalculationPeriod { get; init; }

    /// <summary>
    /// Period during which the security is traded in parallel on the exchange.
    /// </summary>
    [IsoId("_8yJU46tnEfCqjuqNaaNXgw")]
    [DisplayName("Parallel Trading Period")]
    [IsoXmlTag("ParllTradgPrd")]
    public Period12Choice_? ParallelTradingPeriod { get; init; }

    /// <summary>
    /// Period during which the corporate action is valid.
    /// </summary>
    [IsoId("_8yJU5KtnEfCqjuqNaaNXgw")]
    [DisplayName("Action Period")]
    [IsoXmlTag("ActnPrd")]
    public Period6Choice_? ActionPeriod { get; init; }

    /// <summary>
    /// Period during which the instruction can be revoked.
    /// </summary>
    [IsoId("_8yJU5atnEfCqjuqNaaNXgw")]
    [DisplayName("Revocability Period")]
    [IsoXmlTag("RvcbltyPrd")]
    public Period6Choice_? RevocabilityPeriod { get; init; }

    /// <summary>
    /// Period during which the privilege is suspended.
    /// </summary>
    [IsoId("_8yJU5qtnEfCqjuqNaaNXgw")]
    [DisplayName("Privilege Suspension Period")]
    [IsoXmlTag("PrvlgSspnsnPrd")]
    public Period6Choice_? PrivilegeSuspensionPeriod { get; init; }

    /// <summary>
    /// Period during which the account servicer can revoke the instruction.
    /// </summary>
    [IsoId("_8yJU56tnEfCqjuqNaaNXgw")]
    [DisplayName("Account Servicer Revocability Period")]
    [IsoXmlTag("AcctSvcrRvcbltyPrd")]
    public Period6Choice_? AccountServicerRevocabilityPeriod { get; init; }

    /// <summary>
    /// Period during which the depository suspends withdrawal of a security.
    /// </summary>
    [IsoId("_8yJU6KtnEfCqjuqNaaNXgw")]
    [DisplayName("Depository Suspension Period For Withdrawal")]
    [IsoXmlTag("DpstrySspnsnPrdForWdrwl")]
    public Period12Choice_? DepositorySuspensionPeriodForWithdrawal { get; init; }
}
