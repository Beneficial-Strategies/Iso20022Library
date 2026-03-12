// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason6Choice
{
    /// <summary>
    /// Specifies the reason why the instruction has a failing settlement status.
    /// </summary>
    [IsoId("_itAoG0AAEeCaq78Ig8ATcA")]
    [DisplayName("Failing Reason")]
    public partial record FailingReason : Reason6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
