// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reason6Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// </summary>
    [IsoId("_itAoKEAAEeCaq78Ig8ATcA")]
    [DisplayName("Pending Processing Reason")]
    public partial record PendingProcessingReason : Reason6Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("PdgPrcgRsn")]
        public required PendingProcessingReason1Choice_ Value { get; init; }
    }
}
