// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat28Choice
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_WUMGOn0qEeO-puV1mV96Kg")]
    [DisplayName("Date Code")]
    public partial record DateCode : DateFormat28Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of dates.
        /// </summary>
        [IsoXmlTag("DtCd")]
        public required DateType8Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
