// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BreakDown1Choice
{
    /// <summary>
    /// The intention to pay is based on a commercial invoice.
    /// </summary>
    [IsoId("_6n8NYBrYEeOVR9VN6fAMUg")]
    [DisplayName("By Commercial Invoice")]
    [IsoXmlTag("ByComrclInvc")]
    public record ByCommercialInvoice : BreakDown1Choice_
    {
        /// <summary>
        /// Reference to the identification of the underlying commercial document.
        /// </summary>
        [IsoId("_Ti7gwRrYEeOVR9VN6fAMUg")]
        [DisplayName("Commercial Document Reference")]
        [IsoXmlTag("ComrclDocRef")]
        public required InvoiceIdentification1 CommercialDocumentReference { get; init; }

        /// <summary>
        /// Specifies the adjustments applied to obtain the net amount.
        /// </summary>
        [IsoId("_Ti7gwxrYEeOVR9VN6fAMUg")]
        [DisplayName("Adjustment")]
        [IsoXmlTag("Adjstmnt")]
        public Adjustment6? Adjustment { get; init; }

        /// <summary>
        /// Net amount, after adjustments, intended to be paid.
        /// </summary>
        [IsoId("_Ti7gxRrYEeOVR9VN6fAMUg")]
        [DisplayName("Net Amount")]
        [IsoXmlTag("NetAmt")]
        public required CurrencyAndAmount NetAmount { get; init; }

        /// <summary>
        /// Specifies how the net amount to be paid is related to different purchase orders.
        /// </summary>
        [IsoId("_Ti7gxxrYEeOVR9VN6fAMUg")]
        [DisplayName("Breakdown By Purchase Order")]
        [IsoXmlTag("BrkdwnByPurchsOrdr")]
        public ValueList<ReportLine7> BreakdownByPurchaseOrder { get; init; } = [];
        // ID for the above is _Ti7gxxrYEeOVR9VN6fAMUg
    }
}
