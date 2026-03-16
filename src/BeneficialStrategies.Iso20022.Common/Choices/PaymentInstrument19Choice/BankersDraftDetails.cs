// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument19Choice
{
    /// <summary>
    /// Settlement instructions for a payment by draft.
    /// </summary>
    [IsoId("_-mXAlSC1EeWJd9HF2tO7BA")]
    [DisplayName("Bankers Draft Details")]
    public record BankersDraftDetails : PaymentInstrument19Choice_
    {
        /// <summary>
        /// Party to which a cheque is made payable.
        /// </summary>
        [IsoId("_QbdK-tp-Ed-ak6NoX_4Aeg_-2038541815")]
        [DisplayName("Payee Identification")]
        [IsoXmlTag("PyeeId")]
        public required NameAndAddress5 PayeeIdentification { get; init; }
    }
}
