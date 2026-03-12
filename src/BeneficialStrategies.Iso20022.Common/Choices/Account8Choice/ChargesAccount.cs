// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Account8Choice
{
    /// <summary>
    /// Account to be used for charges if different from the account for payment.
    /// </summary>
    [IsoId("_Q4z1U9p-Ed-ak6NoX_4Aeg_-1681750947")]
    [DisplayName("Charges Account")]
    public partial record ChargesAccount : Account8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
