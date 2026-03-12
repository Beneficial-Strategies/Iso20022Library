// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementOrCorporateActionEvent16Choice
{
    /// <summary>
    /// Identifies the type of securities transaction.
    /// </summary>
    [IsoId("_8bir75NLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Transaction Type")]
    public partial record SecuritiesTransactionType : SettlementOrCorporateActionEvent16Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
