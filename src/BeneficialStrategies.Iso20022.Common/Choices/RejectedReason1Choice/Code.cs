// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason1Choice
{
    /// <summary>
    /// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    [IsoId("_QyZrV9p-Ed-ak6NoX_4Aeg_31870363")]
    [DisplayName("Code")]
    public record Code : RejectedReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RejectionReason17Code Value { get; init; }
    }
}
