// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat4Choice
{
    /// <summary>
    /// The date is not specified, eg, the date is unknown.
    /// </summary>
    [IsoId("_RlgjRdp-Ed-ak6NoX_4Aeg_-1279748182")]
    [DisplayName("Not Specified Date")]
    public partial record NotSpecifiedDate : DateFormat4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dates.
        /// </summary>
        [IsoXmlTag("NotSpcfdDt")]
        public required DateType6Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
