// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportContent1Choice
{
    /// <summary>
    /// BASE-64 encoded report content.
    /// </summary>
    [IsoId("_YoZIMMlWEeuJ35KoBRZFOg")]
    [DisplayName("Binary")]
    public partial record Binary : ReportContent1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Binary data of 20 megabytes (20 Mb) maximum.
        /// </summary>
        [IsoXmlTag("Binry")]
        [IsoSimpleType(IsoSimpleType.Max20MbBinary)]
        public required IsoMax20MbBinary Value { get; init; } 
        
        
        #nullable disable
        
    }
}
