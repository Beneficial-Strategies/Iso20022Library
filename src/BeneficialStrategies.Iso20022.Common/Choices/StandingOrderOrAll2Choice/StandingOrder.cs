// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.StandingOrderOrAll2Choice
{
    /// <summary>
    /// Identification of single standing orders defined with specific characteristics.
    /// </summary>
    [IsoId("_Hv82sW4-EeiU9cctagi5ow")]
    [DisplayName("Standing Order")]
    public partial record StandingOrder : StandingOrderOrAll2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for a standing order, as assigned by the account servicer or the account owner.
        /// </summary>
        [IsoId("_Cj8r424-EeiU9cctagi5ow")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Identification { get; init; } 
        
        /// <summary>
        /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.|.
        /// </summary>
        [IsoId("_Cj8r5W4-EeiU9cctagi5ow")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public required CashAccount38 Account { get; init; } 
        
        /// <summary>
        /// Party that legally owns the account.
        /// </summary>
        [IsoId("_Cj8r524-EeiU9cctagi5ow")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
        
        
        #nullable disable
        
    }
}
