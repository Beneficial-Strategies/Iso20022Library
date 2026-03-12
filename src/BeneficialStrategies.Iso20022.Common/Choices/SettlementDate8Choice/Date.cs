// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SettlementDate8Choice
{
    /// <summary>
    /// Numeric representation of the day of the month and year.
    /// </summary>
    [IsoId("_AcsYg9okEeC60axPepSq7g_-1449291241")]
    [DisplayName("Date")]
    public partial record Date : SettlementDate8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
