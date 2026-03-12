// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementStatus2Choice
{
    /// <summary>
    /// Instruction is failing. Settlement at the instructed settlement date is no longer possible.
    /// </summary>
    [IsoId("_UZ9n49p-Ed-ak6NoX_4Aeg_2080863734")]
    [DisplayName("Failing")]
    public partial record Failing : SettlementStatus2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
