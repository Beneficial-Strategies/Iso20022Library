// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DisputeResolutionType1Choice
{
    /// <summary>
    /// Code to specify the type of dispute that is to be resolved regarding the disputed collateral amount.
    /// </summary>
    [IsoId("_QmogNtp-Ed-ak6NoX_4Aeg_1461066692")]
    [DisplayName("Code")]
    public partial record Code : DisputeResolutionType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the disputed collateral amount.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required DisputeResolutionType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
