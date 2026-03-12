// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason6Choice
{
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// </summary>
    [IsoId("_itAoAUAAEeCaq78Ig8ATcA")]
    [DisplayName("Acknowledged Accepted Reason")]
    public partial record AcknowledgedAcceptedReason : Reason6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
