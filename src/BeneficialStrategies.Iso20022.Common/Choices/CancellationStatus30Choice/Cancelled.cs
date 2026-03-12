// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus30Choice
{
    /// <summary>
    /// Specifies the reason why the transaction or instruction is cancelled.
    /// </summary>
    [IsoId("_T_qoARIwEeydmIVkS03esw")]
    [DisplayName("Cancelled")]
    public partial record Cancelled : CancellationStatus30Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
