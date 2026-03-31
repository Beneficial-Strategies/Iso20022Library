// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationResult1Choice
{
    /// <summary>
    /// Provides the investigation status.
    /// </summary>
    [IsoId("_elyCtGgkEeGHuf0_3c6vdw")]
    [DisplayName("Investigation Status")]
    public record InvestigationStatus : InvestigationResult1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the status of the investigation response related to a previously sent request.
        /// </summary>
        [IsoXmlTag("InvstgtnSts")]
        public required InvestigationStatus1Code Value { get; init; }
    }
}
