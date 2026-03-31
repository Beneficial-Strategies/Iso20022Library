// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCodeSearch2Choice
{
    /// <summary>
    /// Qualifies further the final status.
    /// </summary>
    [IsoId("_RGEOMtp-Ed-ak6NoX_4Aeg_396814157")]
    [DisplayName("Final Status")]
    public record FinalStatus : PaymentStatusCodeSearch2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the final status of a transaction.
        /// </summary>
        [IsoXmlTag("FnlSts")]
        public required FinalStatusCode Value { get; init; }
    }
}
