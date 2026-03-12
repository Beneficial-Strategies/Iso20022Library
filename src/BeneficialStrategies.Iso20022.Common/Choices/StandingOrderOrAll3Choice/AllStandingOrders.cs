// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll3Choice
{
    /// <summary>
    /// Identification of all standing orders defined with specific characteristics.
    /// </summary>
    [IsoId("_ex1mY9cZEeqRFcf2R4bPBw")]
    [DisplayName("All Standing Orders")]
    public partial record AllStandingOrders : StandingOrderOrAll3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
        /// </summary>
        [IsoId("_ezPUkdcZEeqRFcf2R4bPBw")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public required CashAccount40 Account { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_ezPUk9cZEeqRFcf2R4bPBw")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
        
        
        #nullable disable
        
    }
}
