// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ReportParameter2Choice
{
    /// <summary>
    /// Party for which the estimated cash flow is being reported.
    /// </summary>
    [IsoId("_U1-1gNp-Ed-ak6NoX_4Aeg_-922147102")]
    [DisplayName("Party")]
    public partial record Party : ReportParameter2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
