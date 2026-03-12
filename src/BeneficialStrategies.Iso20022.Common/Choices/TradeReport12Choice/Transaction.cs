// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TradeReport12Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_bQpIgxLBEeqctpBfTmLJnw")]
    [DisplayName("Transaction")]
    public partial record Transaction : TradeReport12Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
