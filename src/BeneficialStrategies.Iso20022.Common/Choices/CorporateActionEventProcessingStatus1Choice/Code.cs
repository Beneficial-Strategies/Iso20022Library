// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventProcessingStatus1Choice
{
    /// <summary>
    /// Status of a corporate action or the status of a payment expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qsl-RNp-Ed-ak6NoX_4Aeg_-1300232804")]
    [DisplayName("Code")]
    public partial record Code : CorporateActionEventProcessingStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the stage in the corporate action event life cycle.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionEventProcessingStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
