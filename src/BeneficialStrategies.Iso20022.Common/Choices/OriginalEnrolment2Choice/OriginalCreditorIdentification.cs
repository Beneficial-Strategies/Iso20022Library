// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OriginalEnrolment2Choice
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the original creditor.
    /// Usage:
    /// This element must be identical to the creditor identification in the original creditor enrolment.
    /// </summary>
    [IsoId("_UZbOIeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Creditor Identification")]
    public partial record OriginalCreditorIdentification : OriginalEnrolment2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
