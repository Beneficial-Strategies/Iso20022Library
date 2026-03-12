// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason12Choice
{
    /// <summary>
    /// Specifies the reason why the request was denied.
    /// </summary>
    [IsoId("_C2YFuyRhEeO8sskhVI3IDA")]
    [DisplayName("Denied Reason")]
    public partial record DeniedReason : Reason12Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
