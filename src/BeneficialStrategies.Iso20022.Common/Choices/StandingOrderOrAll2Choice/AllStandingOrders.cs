// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll2Choice
{
    /// <summary>
    /// Identification of all standing orders defined with specific characteristics.
    /// </summary>
    [IsoId("_Hv82s24-EeiU9cctagi5ow")]
    [DisplayName("All Standing Orders")]
    public partial record AllStandingOrders : StandingOrderOrAll2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.|.
        /// </summary>
        [IsoId("_H5VcMW4-EeiU9cctagi5ow")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public required CashAccount38 Account { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_H5VcM24-EeiU9cctagi5ow")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
        
        
        #nullable disable
        
    }
}
