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
[IsoId("_JNDucf8REemYYvJytExgzA")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument18
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_JiCf8f8REemYYvJytExgzA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Amount of the payment.
    /// </summary>
    [IsoId("_JiCf8_8REemYYvJytExgzA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Date of the payment.
    /// </summary>
    [IsoId("_JiCf9f8REemYYvJytExgzA")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PaymentDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_JiCf9_8REemYYvJytExgzA")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentInstrument25Choice_? CashSettlementDetails { get; init; }
}
