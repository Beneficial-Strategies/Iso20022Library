// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus9Choice
{
    /// <summary>
    /// Instruction is pending. Settlement at the instructed settlement date is still possible.
    /// </summary>
    [IsoId("_mz-M-_41EeClUvPNHKL9Zw")]
    [DisplayName("Pending")]
    public partial record Pending : SettlementStatus9Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
