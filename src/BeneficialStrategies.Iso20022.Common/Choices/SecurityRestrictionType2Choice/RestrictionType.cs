// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityRestrictionType2Choice
{
    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    [IsoId("_dF_Po-LxEeWOD7aAy2fAcA")]
    [DisplayName("Restriction Type")]
    public record RestrictionType : SecurityRestrictionType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of restriction.
        /// </summary>
        [IsoXmlTag("RstrctnTp")]
        public required RestrictionType1Code Value { get; init; }
    }
}
