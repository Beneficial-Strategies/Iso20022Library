// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralStatus3Choice
{
    /// <summary>
    /// Instruction is pending.
    /// </summary>
    [IsoId("_g1stYOCgEei2UYJ62ws-Fw")]
    [DisplayName("Pending")]
    public partial record Pending : CollateralStatus3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Proprietary identification of the reason related to a status.
        /// </summary>
        [IsoId("_RA3_Uzp5EeWVrPy0StzzSg")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public GenericIdentification30? Reason { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_RA3_Wzp5EeWVrPy0StzzSg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
