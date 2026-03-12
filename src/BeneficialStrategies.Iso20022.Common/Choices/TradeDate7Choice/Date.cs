// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeDate7Choice
{
    /// <summary>
    /// Date and time at which the securities are to be traded.
    /// </summary>
    [IsoId("_DaQH4ZBhEeakHoV5BVecAQ")]
    [DisplayName("Date")]
    public partial record Date : TradeDate7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
