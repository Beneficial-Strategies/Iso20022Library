// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashInOrOut7Choice
{
    /// <summary>
    /// Payment instrument for the cash-in flow.
    /// </summary>
    [IsoId("_3zQJUzbsEead9bDRE_1DAQ")]
    [DisplayName("Cash In Payment Instrument")]
    public partial record CashInPaymentInstrument : CashInOrOut7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
