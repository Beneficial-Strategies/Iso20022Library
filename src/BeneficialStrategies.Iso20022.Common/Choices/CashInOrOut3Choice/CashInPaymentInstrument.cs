// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashInOrOut3Choice
{
    /// <summary>
    /// Payment instrument for the cash-in flow.
    /// </summary>
    [IsoId("_VKP1UNp-Ed-ak6NoX_4Aeg_2056585928")]
    [DisplayName("Cash In Payment Instrument")]
    public partial record CashInPaymentInstrument : CashInOrOut3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
