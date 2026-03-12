// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status2Choice
{
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_UaQi19p-Ed-ak6NoX_4Aeg_1493202851")]
    [DisplayName("Settlement Status")]
    public partial record SettlementStatus : Status2Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
