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
namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters2Choice
{
    /// <summary>
    /// Parameters to be used by the security scheme update command.
    /// </summary>
    [IsoId("_3rN4AItHEeSxlKlAGYErFg")]
    [DisplayName("Required Security Scheme")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RequiredSecurityScheme : ATMCommandParameters2Choice_
    #else
    public partial class RequiredSecurityScheme : ATMCommandParameters2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RequiredSecurityScheme instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RequiredSecurityScheme( ATMSecurityScheme2Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Key exchange security schemes implemented in the hardware security module of the ATM.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ReqrdSctySchme")]
        #endif
        [IsoXmlTag("ReqrdSctySchme")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ATMSecurityScheme2Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ATMSecurityScheme2Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ATMSecurityScheme2Code Value { get; init; } 
        #else
        public ATMSecurityScheme2Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
