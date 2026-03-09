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
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature9Choice
{
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_iAf0Qz7KEeq0cMLnAmm7Lg")]
    [DisplayName("Non Financial Institution")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NonFinancialInstitution : CounterpartyTradeNature9Choice_
    #else
    public partial class NonFinancialInstitution : CounterpartyTradeNature9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NonFinancialInstitution instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NonFinancialInstitution( NoReasonCode reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Indicates that reporting party is a central counterparty.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NFI")]
        #endif
        [IsoXmlTag("NFI")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required NoReasonCode Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required NoReasonCode Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NoReasonCode Value { get; init; } 
        #else
        public NoReasonCode Value { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the non-financial institution.
        /// </summary>
        [IsoId("_VWgswAbWEeqrW7Meu5r3kQ")]
        [DisplayName("Non Financial Institution Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NFIIdr")]
        #endif
        [IsoXmlTag("NFIIdr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NonFinancialInstitutionSector2? NonFinancialInstitutionIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NonFinancialInstitutionSector2? NonFinancialInstitutionIdentifier { get; init; } 
        #else
        public NonFinancialInstitutionSector2? NonFinancialInstitutionIdentifier { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
