// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeDate9Choice
{
    /// <summary>
    /// Date expressed as an ISO date.
    /// </summary>
    [IsoId("_qImeC83yEee5nJBZsW8MFQ")]
    [DisplayName("Date")]
    public partial record Date : TradeDate9Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
