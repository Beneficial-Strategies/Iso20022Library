// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RequestType4Choice
{
    /// <summary>
    /// Request type is a control command on a set of transactions.
    /// </summary>
    [IsoId("_i375oZIhEeect698_YsnIA")]
    [DisplayName("Payment Control")]
    public record PaymentControl : RequestType4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external request type code for a payment control command in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code set published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("PmtCtrl")]
        public required ExternalPaymentControlRequestType1Code Value { get; init; }
    }
}
