// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of a telecom line item.
/// </summary>
[IsoId("_aRwo0VXaEfC0lMwgjvMClw")]
[DisplayName("Telecom Line Item Amount1")]
public record TelecomLineItemAmount1
{
    /// <summary>
    /// Type of telephone charge. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_aRwo0VXaEfC0lMwgjvMClw-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TypeOfAmount25Code? Type { get; init; }

    /// <summary>
    /// Contains the amount.
    /// </summary>
    [IsoId("_aRwo0VXaEfC0lMwgjvMClw-amt")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// A code to indicate the tax amount is credit or debit.
    /// </summary>
    [IsoId("_aRwo0VXaEfC0lMwgjvMClw-crdb")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
