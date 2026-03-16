// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Summary information about amount financed.
/// </summary>
[IsoId("_Th7zwdp-Ed-ak6NoX_4Aeg_-1462438308")]
[DisplayName("Financing Allowed Summary")]
public record FinancingAllowedSummary1
{
    /// <summary>
    /// Number of invoices/instalments financed.
    /// </summary>
    [IsoId("_Th7zwtp-Ed-ak6NoX_4Aeg_-1027457607")]
    [DisplayName("Financed Item Number")]
    [IsoXmlTag("FincdItmNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber FinancedItemNumber { get; init; }

    /// <summary>
    /// Sum of the original total amounts of the invoices accepted for financing.
    /// </summary>
    [IsoId("_Th7zw9p-Ed-ak6NoX_4Aeg_-525987159")]
    [DisplayName("Total Accepted Items Amount")]
    [IsoXmlTag("TtlAccptdItmsAmt")]
    public required ActiveCurrencyAndAmount TotalAcceptedItemsAmount { get; init; }

    /// <summary>
    /// Percentage rate applied to calculate the total amount financed related to the total amounts of the invoices accepted for financing. It represents the average percentage rate applied to all single invoice requests financed. It can be calculated as result of &quot;TotalFinancedAmount&quot; divided by &quot;TotalAcceptedItemsAmount&quot;.
    /// </summary>
    [IsoId("_TiFksNp-Ed-ak6NoX_4Aeg_2267645")]
    [DisplayName("Applied Percentage")]
    [IsoXmlTag("ApldPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AppliedPercentage { get; init; }

    /// <summary>
    /// Total amount financed, defined as the entire financed amount of the requests.
    /// </summary>
    [IsoId("_TiFksdp-Ed-ak6NoX_4Aeg_319034603")]
    [DisplayName("Total Financed Amount")]
    [IsoXmlTag("TtlFincdAmt")]
    public required ActiveCurrencyAndAmount TotalFinancedAmount { get; init; }

    /// <summary>
    /// Set of dates (eg book date, credit date) related to the crediting of the financed amount.
    /// </summary>
    [IsoId("_TiFkstp-Ed-ak6NoX_4Aeg_-1526604541")]
    [DisplayName("Financing Date Details")]
    [IsoXmlTag("FincgDtDtls")]
    public FinancingDateDetails1? FinancingDateDetails { get; init; }

    /// <summary>
    /// Unambiguous identification of the account, held by Financing Requestor, actually used for crediting the amount financed.
    /// </summary>
    [IsoId("_TiFks9p-Ed-ak6NoX_4Aeg_-434448310")]
    [DisplayName("Credit Account")]
    [IsoXmlTag("CdtAcct")]
    public CashAccount7? CreditAccount { get; init; }

    /// <summary>
    /// Unambiguous identification of the internal bank account actually used by First Agent to manage the line of credit granted to Financing Requestor.
    /// </summary>
    [IsoId("_TiFktNp-Ed-ak6NoX_4Aeg_-1667612693")]
    [DisplayName("Financing Account")]
    [IsoXmlTag("FincgAcct")]
    public CashAccount7? FinancingAccount { get; init; }
}
