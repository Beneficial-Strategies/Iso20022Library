// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionInformationStatus1Choice
{
    /// <summary>
    /// Provides information about the rejection status.
    /// </summary>
    [IsoId("_RiPM1Np-Ed-ak6NoX_4Aeg_-878703757")]
    [DisplayName("Rejected Status")]
    public partial record RejectedStatus : CorporateActionInformationStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The rejection reason.
        /// </summary>
        [IsoId("_Rknyddp-Ed-ak6NoX_4Aeg_35582095")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public ValueList<RejectionReason15FormatChoice_> Reason { get; init; } = new ValueList<RejectionReason15FormatChoice_>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _Rknyddp-Ed-ak6NoX_4Aeg_35582095
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_Rknydtp-Ed-ak6NoX_4Aeg_35582096")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
