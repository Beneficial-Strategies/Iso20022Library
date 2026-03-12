// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructedOrQuantityToReceive1Choice
{
    /// <summary>
    /// Quantity of the benefits that the account owner wants to receive, for example, as a result of dividend reinvestment.
    /// </summary>
    [IsoId("_UHL10Np-Ed-ak6NoX_4Aeg_-1856405188")]
    [DisplayName("Quantity To Receive")]
    public partial record QuantityToReceive : InstructedOrQuantityToReceive1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
