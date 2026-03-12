// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TimeFrame3Choice
{
    /// <summary>
    /// An agreed number of days before the Renunciation of Title documents are received used to define standard timeframes in redemption.
    /// </summary>
    [IsoId("_UAyS5Np-Ed-ak6NoX_4Aeg_669671936")]
    [DisplayName("Renunciation Minus")]
    public partial record RenunciationMinus : TimeFrame3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as an integer.
        /// </summary>
        [IsoXmlTag("RMns")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
