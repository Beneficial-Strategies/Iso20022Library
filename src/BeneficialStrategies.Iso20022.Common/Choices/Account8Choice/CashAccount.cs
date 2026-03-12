// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Account8Choice
{
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_Q4z1Utp-Ed-ak6NoX_4Aeg_-1708533047")]
    [DisplayName("Cash Account")]
    public partial record CashAccount : Account8Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
