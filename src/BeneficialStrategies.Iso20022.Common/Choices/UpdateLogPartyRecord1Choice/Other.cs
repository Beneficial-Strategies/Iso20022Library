// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateLogPartyRecord1Choice
{
    /// <summary>
    /// Specifies a proprietary update type.
    /// </summary>
    [IsoId("_7aOnsWjNEeiRg5NzP0jkQg")]
    [DisplayName("Other")]
    public partial record Other : UpdateLogPartyRecord1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name of the field whose value has been changed.
        /// </summary>
        [IsoId("_LituOWjOEeiRg5NzP0jkQg")]
        [DisplayName("Field Name")]
        [IsoXmlTag("FldNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text FieldName { get; init; } 
        
        /// <summary>
        /// Value of the field before the change.
        /// </summary>
        [IsoId("_LituPmjOEeiRg5NzP0jkQg")]
        [DisplayName("Old Field Value")]
        [IsoXmlTag("OdFldVal")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text OldFieldValue { get; init; } 
        
        /// <summary>
        /// Value of the field after the change.
        /// </summary>
        [IsoId("_LituPGjOEeiRg5NzP0jkQg")]
        [DisplayName("New Field Value")]
        [IsoXmlTag("NewFldVal")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text NewFieldValue { get; init; } 
        
        
        #nullable disable
        
    }
}
