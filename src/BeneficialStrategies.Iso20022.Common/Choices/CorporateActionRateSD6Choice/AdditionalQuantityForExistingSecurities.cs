// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CorporateActionRateSD6Choice
{
    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_1kW2YDL3EeKU9IrkkToqcw_408025491")]
    [DisplayName("Additional Quantity For Existing Securities")]
    public partial record AdditionalQuantityForExistingSecurities : CorporateActionRateSD6Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
