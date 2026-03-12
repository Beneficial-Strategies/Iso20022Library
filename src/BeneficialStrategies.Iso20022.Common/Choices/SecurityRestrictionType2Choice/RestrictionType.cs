// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityRestrictionType2Choice
{
    /// <summary>
    /// Type of the restriction, for example, selling restriction, buying restriction, placing restriction.
    /// </summary>
    [IsoId("_dF_Po-LxEeWOD7aAy2fAcA")]
    [DisplayName("Restriction Type")]
    public partial record RestrictionType : SecurityRestrictionType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of restriction.
        /// </summary>
        [IsoXmlTag("RstrctnTp")]
        public required RestrictionType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
