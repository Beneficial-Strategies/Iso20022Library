// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntermediaryRoleChoice1
{
    /// <summary>
    /// Role of the party in the activity.
    /// </summary>
    [IsoId("_RhC6B9p-Ed-ak6NoX_4Aeg_1630269497")]
    [DisplayName("Role")]
    public partial record Role : IntermediaryRoleChoice1_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role played by an actor in an investment fund transaction.
        /// </summary>
        [IsoXmlTag("Role")]
        public required InvestmentFundRole4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
