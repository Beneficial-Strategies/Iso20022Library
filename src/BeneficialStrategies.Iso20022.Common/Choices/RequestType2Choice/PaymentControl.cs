// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RequestType2Choice
{
    /// <summary>
    /// Request type is a control command on a set of transactions.
    /// </summary>
    [IsoId("_76G8c6MgEeCJ6YNENx4h-w_-1082024094")]
    [DisplayName("Payment Control")]
    public record PaymentControl : RequestType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the request used to further detail the type of information that will be queried.
        /// </summary>
        [IsoXmlTag("PmtCtrl")]
        public required RequestType1Code Value { get; init; }
    }
}
