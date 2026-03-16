// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AllocationSatus1Choice
{
    /// <summary>
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [IsoId("_UX39MNp-Ed-ak6NoX_4Aeg_-2141684730")]
    [DisplayName("Code")]
    public record Code : AllocationSatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of allocation of collateral to cover the instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AllocationStatus1Code Value { get; init; }
    }
}
