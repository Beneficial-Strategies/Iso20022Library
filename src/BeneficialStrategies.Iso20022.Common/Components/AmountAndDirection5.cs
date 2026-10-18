// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IAmountAndDirection5"/>
[IsoId("_T2Wkhdp-Ed-ak6NoX_4Aeg_-2124038249")]
[DisplayName("Amount And Direction")]
public partial record AmountAndDirection5
{
    /// <inheritdoc cref="IAmountAndDirection5.Amount"/>
    [IsoId("_T2Wkhtp-Ed-ak6NoX_4Aeg_-2090791440")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <inheritdoc cref="IAmountAndDirection5.CreditDebit"/>
    [IsoId("_T2Wkh9p-Ed-ak6NoX_4Aeg_-2037226790")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebitCode? CreditDebit { get; init; }
}
