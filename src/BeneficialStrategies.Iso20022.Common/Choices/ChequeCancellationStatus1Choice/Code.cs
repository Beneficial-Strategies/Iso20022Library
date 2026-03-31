// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChequeCancellationStatus1Choice
{
    /// <summary>
    /// Status, in a coded form, as published in an external code set.
    /// </summary>
    [IsoId("_PJJT_LtyEeq_cfXrH83Rcw")]
    [DisplayName("Code")]
    public record Code : ChequeCancellationStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external cheque cancellation status code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code set published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalChequeCancellationStatus1Code Value { get; init; }
    }
}
