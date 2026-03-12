// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References45Choice
{
    /// <summary>
    /// Reference to the intra-position movement transaction requested to be cancelled as known by the account owner (or instructing party acting on its behalf).
    /// </summary>
    [IsoId("_R6S2oztpEeWHYdqXF6YZmg")]
    [DisplayName("Intra Position Movement Identification")]
    public partial record IntraPositionMovementIdentification : References45Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("IntraPosMvmntId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
