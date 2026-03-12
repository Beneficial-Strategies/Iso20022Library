// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus7Choice
{
    /// <summary>
    /// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
    /// </summary>
    [IsoId("_Bsv4Nf40EeClUvPNHKL9Zw")]
    [DisplayName("Failing")]
    public partial record Failing : SettlementStatus7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
