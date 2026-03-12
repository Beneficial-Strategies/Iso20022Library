// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus2Choice
{
    /// <summary>
    /// Reason for the rejection of a modification request, in a coded form.
    /// </summary>
    [IsoId("_T-P8Rtp-Ed-ak6NoX_4Aeg_523812729")]
    [DisplayName("Rejected Modification")]
    public partial record RejectedModification : InvestigationStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason for rejecting a modification reject.
        /// </summary>
        [IsoXmlTag("RjctdMod")]
        public required ModificationRejection2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
