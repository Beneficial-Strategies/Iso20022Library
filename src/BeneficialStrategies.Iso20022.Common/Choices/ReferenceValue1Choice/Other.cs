// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReferenceValue1Choice
{
    /// <summary>
    /// Other type of reference.
    /// </summary>
    [IsoId("_rIqsMMeQEeysUoBKYz1Ytw")]
    [DisplayName("Other")]
    public partial record Other : ReferenceValue1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Type of reference
        /// </summary>
        [IsoId("_GZsGAMeUEeysUoBKYz1Ytw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required ReferenceType1Choice_ Type { get; init; } 
        
        /// <summary>
        /// Value of the reference
        /// </summary>
        [IsoId("_LuoKYMeUEeysUoBKYz1Ytw")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        public required IsoMax256Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
