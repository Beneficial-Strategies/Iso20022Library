// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to a party as compensation for a service.
/// </summary>
[IsoId("_2BohoRt9EeOqSdXzJ0oydA")]
[DisplayName("Commission")]
public record Commission17
{
    /// <summary>
    /// Service for which the commission is asked or paid.
    /// </summary>
    [IsoId("_4oDp8BuAEeOqSdXzJ0oydA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CommissionType3Choice_ Type { get; init; }

    /// <summary>
    /// Basis upon which a commission is charged, for example, flat fee.
    /// </summary>
    [IsoId("_EChssBuCEeOqSdXzJ0oydA")]
    [DisplayName("Basis")]
    [IsoXmlTag("Bsis")]
    public required CommissionBasis1Choice_ Basis { get; init; }

    /// <summary>
    /// Commission expressed as an amount of money.
    /// </summary>
    [IsoId("_2aLkjRt9EeOqSdXzJ0oydA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Party entitled to the amount of money resulting from a commission.
    /// </summary>
    [IsoId("_2aLkjxt9EeOqSdXzJ0oydA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; }

    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    [IsoId("_2aLkkRt9EeOqSdXzJ0oydA")]
    [DisplayName("Commercial Agreement Reference")]
    [IsoXmlTag("ComrclAgrmtRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommercialAgreementReference { get; init; }

    /// <summary>
    /// Voluntary non-enforcement of the right to part of a commission.
    /// </summary>
    [IsoId("_z9RD4BuCEeOqSdXzJ0oydA")]
    [DisplayName("Waiving Details")]
    [IsoXmlTag("WvgDtls")]
    public CommissionWaiver4? WaivingDetails { get; init; }
}
