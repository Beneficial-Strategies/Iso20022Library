// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeDate4Choice
{
    /// <summary>
    /// Date and time at which the securities are to be traded.
    /// </summary>
    [IsoId("_AXK_UtokEeC60axPepSq7g_1512121673")]
    [DisplayName("Date")]
    public partial record Date : TradeDate4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
