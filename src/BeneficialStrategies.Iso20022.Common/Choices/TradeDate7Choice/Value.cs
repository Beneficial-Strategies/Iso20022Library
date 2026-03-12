// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeDate7Choice
{
    /// <summary>
    /// Date and time at which the securities are to be traded expressed as a ISO20022 code.
    /// </summary>
    [IsoId("_DaQH45BhEeakHoV5BVecAQ")]
    [DisplayName("Value")]
    public partial record Value : TradeDate7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
