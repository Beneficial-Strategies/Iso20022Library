// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat66Choice
{
    /// <summary>
    /// Date Code.
    /// </summary>
    [DisplayName("Date Code")]
    public partial record DateCode : DateFormat66Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DtCd")]
        public required DateCode20Choice_ Value { get; init; } 
        
        
        #nullable disable
        
    }
}
