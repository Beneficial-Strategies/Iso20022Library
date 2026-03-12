// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent22Choice
{
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_w71kgaOAEeeDTpy0mhI4TQ")]
    [DisplayName("Securities Transaction Type")]
    public partial record SecuritiesTransactionType : SettlementOrCorporateActionEvent22Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
