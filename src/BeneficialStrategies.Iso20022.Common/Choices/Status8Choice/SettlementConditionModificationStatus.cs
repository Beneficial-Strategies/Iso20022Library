// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status8Choice
{
    /// <summary>
    /// Provides the status of a securities settlement condition modification request.
    /// </summary>
    [IsoId("_w2B8G0ABEeCaq78Ig8ATcA")]
    [DisplayName("Settlement Condition Modification Status")]
    public partial record SettlementConditionModificationStatus : Status8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
