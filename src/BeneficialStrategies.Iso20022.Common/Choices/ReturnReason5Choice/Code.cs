// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice
{
    /// <summary>
    /// Reason for the return, as published in an external reason code list.
    /// </summary>
    [IsoId("_TP6Pktp-Ed-ak6NoX_4Aeg_-1676326035")]
    [DisplayName("Code")]
    public record Code : ReturnReason5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the return reason, as published in an external return reason code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalReturnReason1Code Value { get; init; }
    }
}
