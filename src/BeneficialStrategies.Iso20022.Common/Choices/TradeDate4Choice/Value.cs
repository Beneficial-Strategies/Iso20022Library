// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeDate4Choice
{
    /// <summary>
    /// Date and time at which the securities are to be traded expressed as a ISO20022 code.
    /// </summary>
    [IsoId("_AXK_U9okEeC60axPepSq7g_-838039776")]
    [DisplayName("Value")]
    public partial record Value : TradeDate4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
