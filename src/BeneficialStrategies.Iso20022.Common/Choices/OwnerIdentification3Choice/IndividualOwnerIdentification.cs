// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OwnerIdentification3Choice
{
    /// <summary>
    /// Identification of the individual person.
    /// </summary>
    [IsoId("_CKjZsZTREemC09f0MxYkRg")]
    [DisplayName("Individual Owner Identification")]
    public partial record IndividualOwnerIdentification : OwnerIdentification3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
