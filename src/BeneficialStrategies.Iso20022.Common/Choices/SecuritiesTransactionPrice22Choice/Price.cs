// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice22Choice
{
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_i7UncZiuEe2f7NHvXATP5g")]
    [DisplayName("Price")]
    public partial record Price : SecuritiesTransactionPrice22Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
