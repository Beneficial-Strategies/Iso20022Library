// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingInstructionStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RirRsdp-Ed-ak6NoX_4Aeg_15156423")]
    [DisplayName("Rejected Status")]
    public partial record RejectedStatus : StandingInstructionStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_RlD3U9p-Ed-ak6NoX_4Aeg_-484468439")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason20FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason20FormatChoice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _RlD3U9p-Ed-ak6NoX_4Aeg_-484468439
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RlD3VNp-Ed-ak6NoX_4Aeg_-484468418")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
