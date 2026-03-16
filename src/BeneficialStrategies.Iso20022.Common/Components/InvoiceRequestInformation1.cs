// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics that unambiguously identify the single invoice financing request.
/// </summary>
[IsoId("_RYGZZdp-Ed-ak6NoX_4Aeg_909721344")]
[DisplayName("Invoice Request Information")]
public record InvoiceRequestInformation1
{
    /// <summary>
    /// General information that unambiguously identify the invoice to be financed, such as invoice type, invoice number and issue date.
    /// </summary>
    [IsoId("_RYGZZtp-Ed-ak6NoX_4Aeg_-885319739")]
    [DisplayName("Invoice General Information")]
    [IsoXmlTag("InvcGnlInf")]
    public required DocumentGeneralInformation1 InvoiceGeneralInformation { get; init; }

    /// <summary>
    /// Specifies totals related to the invoice, such as total invoice amount and total tax amount.
    /// </summary>
    [IsoId("_RYGZZ9p-Ed-ak6NoX_4Aeg_88226197")]
    [DisplayName("Invoice Totals Information")]
    [IsoXmlTag("InvcTtlsInf")]
    public required InvoiceTotals1 InvoiceTotalsInformation { get; init; }

    /// <summary>
    /// Amount of credit/debit note related to the invoice to be financed.
    /// </summary>
    [IsoId("_RYGZaNp-Ed-ak6NoX_4Aeg_-1188229274")]
    [DisplayName("Credit Debit Note Amount")]
    [IsoXmlTag("CdtDbtNoteAmt")]
    public ActiveCurrencyAndAmount? CreditDebitNoteAmount { get; init; }

    /// <summary>
    /// Details of a single instalment to be financed, related to an invoice settlement (amount, payment due date).
    /// </summary>
    [IsoId("_RYQKYNp-Ed-ak6NoX_4Aeg_-1603772146")]
    [DisplayName("Instalment Information")]
    [IsoXmlTag("InstlmtInf")]
    public ValueList<Instalment1> InstalmentInformation { get; init; } = [];

    /// <summary>
    /// Amount requested by the requestor party, related to a single invoice to be financed.
    /// </summary>
    [IsoId("_RYQKYdp-Ed-ak6NoX_4Aeg_-1318025183")]
    [DisplayName("Requested Amount")]
    [IsoXmlTag("ReqdAmt")]
    public FinancingRateOrAmountChoice_? RequestedAmount { get; init; }

    /// <summary>
    /// Person or organization that represents the creditor for the invoice to be financed.
    /// </summary>
    [IsoId("_RYQKYtp-Ed-ak6NoX_4Aeg_475463417")]
    [DisplayName("Supplier")]
    [IsoXmlTag("Spplr")]
    public required PartyAndAccountIdentificationAndContactInformation1 Supplier { get; init; }

    /// <summary>
    /// Person or organization that represents the debtor for the invoice to be financed.
    /// </summary>
    [IsoId("_RYQKY9p-Ed-ak6NoX_4Aeg_1975466452")]
    [DisplayName("Buyer")]
    [IsoXmlTag("Buyr")]
    public required PartyIdentificationAndContactInformation1 Buyer { get; init; }

    /// <summary>
    /// Specifies payment terms and conditions related to a single invoice to be financed, including identifier of possible account used for payment.
    /// </summary>
    [IsoId("_RYQKZNp-Ed-ak6NoX_4Aeg_-1314868221")]
    [DisplayName("Invoice Payment Information")]
    [IsoXmlTag("InvcPmtInf")]
    public required PaymentInformation15 InvoicePaymentInformation { get; init; }

    /// <summary>
    /// Information about a document related to the invoice to be financed, in structured form.
    /// </summary>
    [IsoId("_RYQKZdp-Ed-ak6NoX_4Aeg_497864820")]
    [DisplayName("Referred Document")]
    [IsoXmlTag("RfrdDoc")]
    public ValueList<ReferredDocumentInformation2> ReferredDocument { get; init; } = [];
}
