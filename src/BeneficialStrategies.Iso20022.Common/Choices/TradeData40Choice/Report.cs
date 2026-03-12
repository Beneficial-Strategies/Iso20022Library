// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeData40Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_ztk1M8g3EeuGrNSsxk3B0A")]
    [DisplayName("Report")]
    public partial record Report : TradeData40Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
