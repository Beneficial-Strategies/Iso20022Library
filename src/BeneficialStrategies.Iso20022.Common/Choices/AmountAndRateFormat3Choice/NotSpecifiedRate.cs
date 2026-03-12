// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AmountAndRateFormat3Choice
{
    /// <summary>
    /// The rate is not specified.
    /// </summary>
    [IsoId("_UIFNtdp-Ed-ak6NoX_4Aeg_896081941")]
    [DisplayName("Not Specified Rate")]
    public partial record NotSpecifiedRate : AmountAndRateFormat3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
