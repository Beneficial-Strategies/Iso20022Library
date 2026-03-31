// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesUpdateReason1Choice
{
    /// <summary>
    /// Update reason, as published in an external code set.
    /// </summary>
    [IsoId("_EjynMpI8EeuAlLVx8pyt3w")]
    [DisplayName("Code")]
    public record Code : SecuritiesUpdateReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the securities update reason, as published in an external securities update reason code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalSecuritiesUpdateReason1Code Value { get; init; }
    }
}
