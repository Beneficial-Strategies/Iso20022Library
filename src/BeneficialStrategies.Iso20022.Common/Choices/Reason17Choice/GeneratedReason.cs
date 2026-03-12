// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason17Choice
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    [IsoId("_8Qc12ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Generated Reason")]
    public partial record GeneratedReason : Reason17Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
