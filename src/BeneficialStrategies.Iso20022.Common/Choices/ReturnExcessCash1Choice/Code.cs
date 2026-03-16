// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReturnExcessCash1Choice
{
    /// <summary>
    /// Return excess cash type expressed as a code.
    /// </summary>
    [IsoId("_UN9QYALpEeutW5-TpeYJhA")]
    [DisplayName("Code")]
    public record Code : ReturnExcessCash1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies information about excess cash.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ReturnExcessCash1Code Value { get; init; }
    }
}
