// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat58Choice
{
    /// <summary>
    /// Type of date.
    /// </summary>
    [IsoId("_k8fcua09EemDtrWpq90Ckg")]
    [DisplayName("Date Code")]
    public partial record DateCode : DateFormat58Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies when date is unknown.
        /// </summary>
        [IsoXmlTag("DtCd")]
        public required DateType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
