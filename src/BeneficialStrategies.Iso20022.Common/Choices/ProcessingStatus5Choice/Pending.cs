// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus5Choice
{
    /// <summary>
    /// Modification is pending. It is not known at this time whether modification can be affected.
    /// </summary>
    [IsoId("_UUvwstp-Ed-ak6NoX_4Aeg_-36143454")]
    [DisplayName("Pending")]
    public partial record Pending : ProcessingStatus5Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
