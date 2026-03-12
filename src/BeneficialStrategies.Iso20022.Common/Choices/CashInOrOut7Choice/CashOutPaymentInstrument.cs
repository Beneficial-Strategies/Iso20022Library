// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashInOrOut7Choice
{
    /// <summary>
    /// Payment instrument for the cash-out flow.
    /// </summary>
    [IsoId("_3zQJVTbsEead9bDRE_1DAQ")]
    [DisplayName("Cash Out Payment Instrument")]
    public partial record CashOutPaymentInstrument : CashInOrOut7Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
