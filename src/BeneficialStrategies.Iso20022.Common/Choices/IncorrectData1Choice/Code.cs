// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IncorrectData1Choice
{
    /// <summary>
    /// Incorrect data type, in a coded form.
    /// </summary>
    [IsoId("_DfjHsNjLEeq5MfBBxQig1Q")]
    [DisplayName("Code")]
    public record Code : IncorrectData1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason of an unable to apply due to incorrect data, as published in an external unable to apply incorrect data code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalUnableToApplyIncorrectData1Code Value { get; init; }
    }
}
