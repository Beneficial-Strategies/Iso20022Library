// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentificationQuery3Choice
{
    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_P-19C9GgEeaQk737TH1Fzw")]
    [DisplayName("Not Reported")]
    public partial record NotReported : SecurityIdentificationQuery3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a not reported value code.
        /// </summary>
        [IsoXmlTag("NotRptd")]
        public required NotReported1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
