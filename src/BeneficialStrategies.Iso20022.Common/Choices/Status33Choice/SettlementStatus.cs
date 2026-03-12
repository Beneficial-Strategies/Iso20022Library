// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status33Choice
{
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_waWGBSAeEeuyDZ-ukt4YRg")]
    [DisplayName("Settlement Status")]
    public partial record SettlementStatus : Status33Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
