// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClosingDate4Choice
{
    /// <summary>
    /// Closing date is defined using a code or data source scheme.
    /// </summary>
    [IsoId("_xTU6g8pdEemQ1o-hyeYV5w")]
    [DisplayName("Code")]
    public partial record Code : ClosingDate4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
