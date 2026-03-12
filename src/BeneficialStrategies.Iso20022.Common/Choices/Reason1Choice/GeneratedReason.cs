// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Reason1Choice
{
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// </summary>
    [IsoId("_UXlCQdp-Ed-ak6NoX_4Aeg_-1474168343")]
    [DisplayName("Generated Reason")]
    public partial record GeneratedReason : Reason1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
