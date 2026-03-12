// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus4Choice
{
    /// <summary>
    /// Reason for the rejection of a modification request, in a coded form.
    /// </summary>
    [IsoId("_nbwAlYmxEeeKR__nUfxjwA")]
    [DisplayName("Rejected Modification")]
    public partial record RejectedModification : InvestigationStatus4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
