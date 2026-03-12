// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent30Choice
{
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_ZffRUemrEemUgrefIx730g")]
    [DisplayName("Securities Transaction Type")]
    public partial record SecuritiesTransactionType : SettlementOrCorporateActionEvent30Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
