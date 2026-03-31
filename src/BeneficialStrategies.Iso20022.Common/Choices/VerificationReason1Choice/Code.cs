// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.VerificationReason1Choice
{
    /// <summary>
    /// Reason why the verified identification information is incorrect, as published in an external reason code list.
    /// </summary>
    [IsoId("_Qo3U1dp-Ed-ak6NoX_4Aeg_-1342337588")]
    [DisplayName("Code")]
    public record Code : VerificationReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external verification reason code, as published in an external verification code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalVerificationReason1Code Value { get; init; }
    }
}
