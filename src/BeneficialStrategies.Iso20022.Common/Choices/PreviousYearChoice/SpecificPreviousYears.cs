// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PreviousYearChoice
{
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_Rb-Mw9p-Ed-ak6NoX_4Aeg_-59890695")]
    [DisplayName("Specific Previous Years")]
    public partial record SpecificPreviousYears : PreviousYearChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Year represented by YYYY (ISO 8601).
        /// </summary>
        [IsoXmlTag("SpcfcPrvsYrs")]
        [IsoSimpleType(IsoSimpleType.ISOYear)]
        public required IsoISOYear Value { get; init; } 
        
        
        #nullable disable
        
    }
}
