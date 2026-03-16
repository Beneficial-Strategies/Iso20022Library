// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat9Choice
{
    /// <summary>
    /// Standard code to specify the additional business process linked to a corporate action event.
    /// </summary>
    [IsoId("_EjnfYUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public record Code : AdditionalBusinessProcessFormat9Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the additional business process linked to a corporate action event.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AdditionalBusinessProcess5Code Value { get; init; }
    }
}
