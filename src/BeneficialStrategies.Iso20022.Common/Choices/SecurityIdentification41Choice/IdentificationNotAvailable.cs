// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice
{
    /// <summary>
    /// Indicates that underlying identification is not available.
    /// </summary>
    [IsoId("_idD07Vo2Ee23K4GXSpBSeg")]
    [DisplayName("Identification Not Available")]
    public record IdentificationNotAvailable : SecurityIdentification41Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of the underlying identification.
        /// </summary>
        [IsoXmlTag("IdNotAvlbl")]
        public required UnderlyingIdentification1Code Value { get; init; }
    }
}
