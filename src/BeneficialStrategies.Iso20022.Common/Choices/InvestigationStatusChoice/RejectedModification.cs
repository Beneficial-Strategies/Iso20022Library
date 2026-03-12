// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatusChoice
{
    /// <summary>
    /// Reason for the rejection of a modification request, in a coded form.
    /// </summary>
    [IsoId("_UuYYtNp-Ed-ak6NoX_4Aeg_-1201676682")]
    [DisplayName("Rejected Modification")]
    public partial record RejectedModification : InvestigationStatusChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the reason for rejecting a modification.
        /// </summary>
        [IsoXmlTag("RjctdMod")]
        public required PaymentModificationRejection1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
