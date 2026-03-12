// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ProcessingStatus14Choice
{
    /// <summary>
    /// Modification is pending. It is not known at this time whether modification can be affected.
    /// </summary>
    [IsoId("_KXLkXfI4Ed-dOvqmSLSz5g")]
    [DisplayName("Pending")]
    public partial record Pending : ProcessingStatus14Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
