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
namespace BeneficialStrategies.Iso20022.Choices.IntermediaryRoleChoice1
{
    /// <summary>
    /// Role of the party in the activity.
    /// </summary>
    [IsoId("_RhC6B9p-Ed-ak6NoX_4Aeg_1630269497")]
    [DisplayName("Role")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Role : IntermediaryRoleChoice1_
    #else
    public partial class Role : IntermediaryRoleChoice1_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Role instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Role( InvestmentFundRole4Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role played by an actor in an investment fund transaction.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Role")]
        #endif
        [IsoXmlTag("Role")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InvestmentFundRole4Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InvestmentFundRole4Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvestmentFundRole4Code Value { get; init; } 
        #else
        public InvestmentFundRole4Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
