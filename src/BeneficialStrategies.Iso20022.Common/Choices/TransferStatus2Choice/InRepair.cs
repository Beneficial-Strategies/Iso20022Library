// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus2Choice
{
    /// <summary>
    /// Status of the transfer is in repair.
    /// </summary>
    [IsoId("_aQ-GNyY3EeW_ZNn8gbfY7Q")]
    [DisplayName("In Repair")]
    public record InRepair : TransferStatus2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("InRpr")]
        public required InRepairStatus4Choice_ Value { get; init; }
    }
}
