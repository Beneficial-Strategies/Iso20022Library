// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SystemIdentification2Choice
{
    /// <summary>
    /// Clearing service selected for a transaction.
    /// </summary>
    [IsoId("_8BZ3QqMgEeCJ6YNENx4h-w_-129556950")]
    [DisplayName("Market Infrastructure Identification")]
    public partial record MarketInfrastructureIdentification : SystemIdentification2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
