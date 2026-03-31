// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus3Choice
{
    /// <summary>
    /// Reason for the rejection of a modification request, in a coded form.
    /// </summary>
    [IsoId("_tx5SA1kyEeGeoaLUQk__nA_-1756023474")]
    [DisplayName("Rejected Modification")]
    public record RejectedModification : InvestigationStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for rejecting a modification reject.
        /// </summary>
        [IsoXmlTag("RjctdMod")]
        public required ModificationRejection2Code Value { get; init; }
    }
}
