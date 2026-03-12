// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status32Choice
{
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_BH0PkQpIEeup4r-PFG2T5Q")]
    [DisplayName("Settlement Status")]
    public partial record SettlementStatus : Status32Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
