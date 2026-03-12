// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Number24Choice
{
    /// <summary>
    /// Number of maximum 4 numeric text.
    /// </summary>
    [IsoId("_6dono5BfEeakHoV5BVecAQ")]
    [DisplayName("Number Identification")]
    public partial record NumberIdentification : Number24Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a numeric string with a maximum length of 4 digits.
        /// </summary>
        [IsoXmlTag("NbId")]
        [IsoSimpleType(IsoSimpleType.Max4NumericText)]
        public required IsoMax4NumericText Value { get; init; } 
        
        
        #nullable disable
        
    }
}
