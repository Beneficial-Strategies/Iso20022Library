// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RenounceableEntitlementStatusTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the renounceable status.
    /// </summary>
    [IsoId("_Q3nigNp-Ed-ak6NoX_4Aeg_1417014639")]
    [DisplayName("Code")]
    public partial record Code : RenounceableEntitlementStatusTypeFormat1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the renounceable status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RenounceableStatus1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
