// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms of the underlying transaction.
/// </summary>
[IsoId("_Prd4dNp-Ed-ak6NoX_4Aeg_851180831")]
[DisplayName("Payment Terms")]
public record PaymentTerms1
{
    /// <summary>
    /// Specifies payment terms not present in a code list.
    /// </summary>
    [IsoId("_Prd4ddp-Ed-ak6NoX_4Aeg_1227100069")]
    [DisplayName("Other Payment Terms")]
    [IsoXmlTag("OthrPmtTerms")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public required IsoMax140Text OtherPaymentTerms { get; init; }

    /// <summary>
    /// Specifies the payment period in coded form and a number of days.
    /// </summary>
    [IsoId("_Prd4dtp-Ed-ak6NoX_4Aeg_-1773090944")]
    [DisplayName("Payment Code")]
    [IsoXmlTag("PmtCd")]
    public required PaymentPeriod1 PaymentCode { get; init; }

    /// <summary>
    /// Specifies that the payment conditions apply to a percentage of the amount due.
    /// </summary>
    [IsoId("_Prd4d9p-Ed-ak6NoX_4Aeg_791045590")]
    [DisplayName("Percentage")]
    [IsoXmlTag("Pctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Percentage { get; init; }

    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_PrnpcNp-Ed-ak6NoX_4Aeg_1065328418")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }
}
