// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment parties for the transfer of cash from the debtor to the creditor.
/// </summary>
[IsoId("bf947de9-3b3b-4e81-a71b-fb3f7cc83a47")]
[DisplayName("Payment Instrument23")]
public record PaymentInstrument23
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    [IsoId("d7bdf619-ac7f-46d5-b4b9-e01bf1780a88")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Amount of the payment.
    /// </summary>
    [IsoId("64262e1a-8a20-44d7-bdd0-e7892c5fa475")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Date of the payment.
    /// </summary>
    [IsoId("f5400023-26a8-4af0-bc3e-16c62aaeaba4")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public IsoISODate? PaymentDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("d7640a41-2811-4d88-9a0d-8e8a52a69b9b")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentInstrument31Choice? CashSettlementDetails { get; init; }
}
