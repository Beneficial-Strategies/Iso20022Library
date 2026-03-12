// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LiquidityPoolMembers1Choice
{
    /// <summary>
    /// Information about head member of liquidity pool.
    /// </summary>
    [IsoId("_zpIWcCDsEeav65mEytrgaA")]
    [DisplayName("Head Member Details")]
    public partial record HeadMemberDetails : LiquidityPoolMembers1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Account identifier.
        /// </summary>
        [IsoId("_UhRGkCDsEeav65mEytrgaA")]
        [DisplayName("Account")]
        [IsoXmlTag("Acct")]
        public required CashAccount24 Account { get; init; } 
        
        /// <summary>
        /// Account owner identification.
        /// </summary>
        [IsoId("_eOrnECDsEeav65mEytrgaA")]
        [DisplayName("Account Owner")]
        [IsoXmlTag("AcctOwnr")]
        public required FinancialInstitutionIdentification9 AccountOwner { get; init; } 
        
        
        #nullable disable
        
    }
}
