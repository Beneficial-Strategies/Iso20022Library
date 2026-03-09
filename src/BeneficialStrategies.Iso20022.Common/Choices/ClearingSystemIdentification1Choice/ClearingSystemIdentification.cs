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
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification1Choice
{
    /// <summary>
    /// Infrastructure through which the payment instruction is processed.
    /// </summary>
    [IsoId("_TMVXINp-Ed-ak6NoX_4Aeg_-843594927")]
    [DisplayName("Clearing System Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ClearingSystemIdentification : ClearingSystemIdentification1Choice_
    #else
    public partial class ClearingSystemIdentification : ClearingSystemIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ClearingSystemIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ClearingSystemIdentification( CashClearingSystem3Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is to be processed.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrSysId")]
        #endif
        [IsoXmlTag("ClrSysId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CashClearingSystem3Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CashClearingSystem3Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashClearingSystem3Code Value { get; init; } 
        #else
        public CashClearingSystem3Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
