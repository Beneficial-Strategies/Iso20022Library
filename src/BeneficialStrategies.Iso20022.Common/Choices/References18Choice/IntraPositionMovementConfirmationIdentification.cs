// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References18Choice
{
    /// <summary>
    /// Unambiguous account servicer identification of the intra-position movement confirmation to be cancelled.
    /// </summary>
    [IsoId("_9EijLT9mEeCuVfEpWlZb5g")]
    [DisplayName("Intra Position Movement Confirmation Identification")]
    public partial record IntraPositionMovementConfirmationIdentification : References18Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("IntraPosMvmntConfId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
