// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GeneratedStatus1Choice
{
    /// <summary>
    /// Specifies the reason of the GeneratedStatus.
    /// </summary>
    [IsoId("_UY7GFdp-Ed-ak6NoX_4Aeg_171466395")]
    [DisplayName("Reason")]
    public partial record Reason : GeneratedStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the transaction was generated.
        /// </summary>
        [IsoId("_UY7GEdp-Ed-ak6NoX_4Aeg_249298948")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required GeneratedReasons1Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UY7GEtp-Ed-ak6NoX_4Aeg_-655509884")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
