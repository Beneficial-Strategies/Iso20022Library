// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice20Choice
{
    /// <summary>
    /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
    /// </summary>
    [IsoId("_IaZdh02vEe2Ci6HlmBLbDw")]
    [DisplayName("Basis Point Spread")]
    public partial record BasisPointSpread : SecuritiesTransactionPrice20Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("BsisPtSprd")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
