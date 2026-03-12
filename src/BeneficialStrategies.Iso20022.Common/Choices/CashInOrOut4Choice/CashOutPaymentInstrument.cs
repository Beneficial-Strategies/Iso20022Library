// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashInOrOut4Choice
{
    /// <summary>
    /// Payment instrument for the cash-out flow.
    /// </summary>
    [IsoId("_VKP1VNp-Ed-ak6NoX_4Aeg_-1582566013")]
    [DisplayName("Cash Out Payment Instrument")]
    public partial record CashOutPaymentInstrument : CashInOrOut4Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
