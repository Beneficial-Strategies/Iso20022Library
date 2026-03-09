// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.LiquidityPoolMembers1Choice
{
    /// <summary>
    /// List of subordinate liquidity pool member.
    /// </summary>
    [IsoId("_2ObkwCDsEeav65mEytrgaA")]
    [DisplayName("Subordinate Member Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SubordinateMemberDetails : LiquidityPoolMembers1Choice_
    #else
    public partial class SubordinateMemberDetails : LiquidityPoolMembers1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// List of the identifier pairs.
        /// </summary>
        [IsoId("_qhLMECDvEeav65mEytrgaA")]
        [DisplayName("List")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="List")]
        #endif
        [IsoXmlTag("List")]
        public ValueList<AccountOwnerAndIdentification1> List { get; init; } = new ValueList<AccountOwnerAndIdentification1>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _qhLMECDvEeav65mEytrgaA
        
        
        #nullable disable
        
    }
}
