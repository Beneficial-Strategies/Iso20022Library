// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ValidityPeriod1Choice
{
    /// <summary>
    /// Validity Period Code.
    /// </summary>
    [DisplayName("Validity Period Code")]
    public partial record ValidityPeriodCode : ValidityPeriod1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("VldtyPrdCd")]
        public required ValidityPeriodType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
