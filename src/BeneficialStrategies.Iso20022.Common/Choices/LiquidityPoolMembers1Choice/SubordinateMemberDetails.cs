// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.LiquidityPoolMembers1Choice
{
    /// <summary>
    /// List of subordinate liquidity pool member.
    /// </summary>
    [IsoId("_2ObkwCDsEeav65mEytrgaA")]
    [DisplayName("Subordinate Member Details")]
    public partial record SubordinateMemberDetails : LiquidityPoolMembers1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// List of the identifier pairs.
        /// </summary>
        [IsoId("_qhLMECDvEeav65mEytrgaA")]
        [DisplayName("List")]
        [IsoXmlTag("List")]
        public ValueList<AccountOwnerAndIdentification1> List { get; init; } = new ValueList<AccountOwnerAndIdentification1>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _qhLMECDvEeav65mEytrgaA
        
        
        #nullable disable
        
    }
}
