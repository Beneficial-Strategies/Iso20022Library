// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus1Choice
{
    /// <summary>
    /// Specifies the reason of the UnmatchedStatus.
    /// </summary>
    [IsoId("_UaHY59p-Ed-ak6NoX_4Aeg_-331326632")]
    [DisplayName("Reason")]
    public partial record Reason : UnmatchedStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has an unmatched status.
        /// </summary>
        [IsoId("_UaHY49p-Ed-ak6NoX_4Aeg_-1780533030")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required UnmatchedReason1Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UaHY5Np-Ed-ak6NoX_4Aeg_-1379840589")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
