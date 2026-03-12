// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ResponseStatus3Choice
{
    /// <summary>
    /// The status of an instruction, advice or request.
    /// </summary>
    [IsoId("_0j-I4wlIEeGATtfOBToyew_-2045784102")]
    [DisplayName("Pending")]
    public partial record Pending : ResponseStatus3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
