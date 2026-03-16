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
[IsoId("_vhmLYVNZEeijdq8ilaxyOA")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument15
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_vxN7wVNZEeijdq8ilaxyOA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Amount of the payment.
    /// </summary>
    [IsoId("_Awm1EFNaEeijdq8ilaxyOA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }

    /// <summary>
    /// Date of the payment.
    /// </summary>
    [IsoId("_K5QgEFNaEeijdq8ilaxyOA")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PaymentDate { get; init; }

    /// <summary>
    /// Payment process for the transfer of cash from the debtor to the creditor.
    /// </summary>
    [IsoId("_M46DoFNaEeijdq8ilaxyOA")]
    [DisplayName("Cash Settlement Details")]
    [IsoXmlTag("CshSttlmDtls")]
    public PaymentInstrument23Choice_? CashSettlementDetails { get; init; }
}
