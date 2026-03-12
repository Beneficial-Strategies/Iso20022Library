// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice4Choice
{
    /// <summary>
    /// Predetermined price at which the holder will have to buy or sell the underlying instrument.
    /// </summary>
    [IsoId("_IEZAAOI_EeWWKb0jFHxViQ")]
    [DisplayName("Price")]
    public partial record Price : SecuritiesTransactionPrice4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
