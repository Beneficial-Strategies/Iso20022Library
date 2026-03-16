// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCodeSearch2Choice
{
    /// <summary>
    /// State of a payment instruction at a specified time.
    /// </summary>
    [IsoId("_RGEOM9p-Ed-ak6NoX_4Aeg_396814260")]
    [DisplayName("Pending And Final Status")]
    public record PendingAndFinalStatus : PaymentStatusCodeSearch2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the state of a payment instruction at a specified time.
        /// </summary>
        [IsoXmlTag("PdgAndFnlSts")]
        public required CashPaymentStatus2Code Value { get; init; }
    }
}
