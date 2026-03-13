// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingInstructionCancellationStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RirRtNp-Ed-ak6NoX_4Aeg_1204907770")]
    [DisplayName("Rejected Status")]
    public partial record RejectedStatus : StandingInstructionCancellationStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_Rk6tZdp-Ed-ak6NoX_4Aeg_1289872620")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason10FormatChoice_> Reason { get; init; } = [];
        // ID for the above is _Rk6tZdp-Ed-ak6NoX_4Aeg_1289872620
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_Rk6tZtp-Ed-ak6NoX_4Aeg_1289872650")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
