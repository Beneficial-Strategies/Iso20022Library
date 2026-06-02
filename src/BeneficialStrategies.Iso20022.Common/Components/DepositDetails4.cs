// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional functions or services to be performed in conjunction with the transaction.
/// </summary>
[IsoId("_rGZAcT_dEfCQAqQ9lolFUg")]
[DisplayName("Deposit Details4")]
public record DepositDetails4
{
    /// <summary>
    /// Funding source used for deposit. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_rIyNIT_dEfCQAqQ9lolFUg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CardDepositType2Code Type { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_rIyNJT_dEfCQAqQ9lolFUg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_rIyNJz_dEfCQAqQ9lolFUg")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
