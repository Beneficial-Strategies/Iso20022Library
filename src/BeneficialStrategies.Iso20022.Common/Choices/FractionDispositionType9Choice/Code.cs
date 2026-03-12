// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FractionDispositionType9Choice
{
    /// <summary>
    /// Standard code to specify how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_zfe2w-HDEd-1Ktb5rVaajw")]
    [DisplayName("Code")]
    public partial record Code : FractionDispositionType9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FractionDispositionType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
