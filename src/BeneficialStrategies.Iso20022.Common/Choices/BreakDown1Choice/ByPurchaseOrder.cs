// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BreakDown1Choice
{
    /// <summary>
    /// The intention to pay is based on a purchase order.
    /// </summary>
    [IsoId("_2goZwBrYEeOVR9VN6fAMUg")]
    [DisplayName("By Purchase Order")]
    public record ByPurchaseOrder : BreakDown1Choice_
    {
        /// <summary>
        /// Unique identification of the purchase order, assigned by the buyer.
        /// </summary>
        [IsoId("_982JIRrXEeOVR9VN6fAMUg")]
        [DisplayName("Purchase Order Reference")]
        [IsoXmlTag("PurchsOrdrRef")]
        public required DocumentIdentification7 PurchaseOrderReference { get; init; }

        /// <summary>
        /// Specifies the adjustments applied to obtain the net amount.
        /// </summary>
        [IsoId("_982JIxrXEeOVR9VN6fAMUg")]
        [DisplayName("Adjustment")]
        [IsoXmlTag("Adjstmnt")]
        public Adjustment6? Adjustment { get; init; }

        /// <summary>
        /// Net amount, after adjustments, intended to be paid.
        /// </summary>
        [IsoId("_982JJRrXEeOVR9VN6fAMUg")]
        [DisplayName("Net Amount")]
        [IsoXmlTag("NetAmt")]
        public required CurrencyAndAmount NetAmount { get; init; }
    }
}
