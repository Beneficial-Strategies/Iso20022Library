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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument9Choice
{
    /// <summary>
    /// Part of the investment account to or from which cash entries are made.
    /// </summary>
    [IsoId("_VK1rM9p-Ed-ak6NoX_4Aeg_1453545196")]
    [DisplayName("Account Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record AccountDetails : PaymentInstrument9Choice_
    #else
    public partial class AccountDetails : PaymentInstrument9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_U9RwVNp-Ed-ak6NoX_4Aeg_-2850192")]
        [DisplayName("Account Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctId")]
        #endif
        [IsoXmlTag("AcctId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentification1? AccountIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentification1? AccountIdentification { get; init; } 
        #else
        public AccountIdentification1? AccountIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Account type.
        /// </summary>
        [IsoId("_U9RwVdp-Ed-ak6NoX_4Aeg_791350549")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccountType1? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccountType1? Type { get; init; } 
        #else
        public CashAccountType1? Type { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
