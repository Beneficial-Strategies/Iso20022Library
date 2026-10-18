// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus79Choice
{
    /// <summary>
    /// Buy-in advice is rejected for further processing.
    /// </summary>
    [IsoId("_HqnHaZwZEeqtp-LOti013g")]
    [DisplayName("Rejected")]
    public partial record Rejected : ProcessingStatus79Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rjctd")]
        public required RejectionOrRepairStatus31Choice_ Value { get; init; }
    }
}
