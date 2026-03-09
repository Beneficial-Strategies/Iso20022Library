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
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument12Choice
{
    /// <summary>
    /// Part of the investment account to or from which cash entries are made.
    /// </summary>
    [IsoId("_SBhw4tp-Ed-ak6NoX_4Aeg_-938859562")]
    [DisplayName("Cash Account Details")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CashAccountDetails : PaymentInstrument12Choice_
    #else
    public partial class CashAccountDetails : PaymentInstrument12Choice_
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
        [IsoId("_Rzq7HNp-Ed-ak6NoX_4Aeg_2054866231")]
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
        [IsoId("_Rzq7Hdp-Ed-ak6NoX_4Aeg_2054866247")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FundCashAccount2Code? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FundCashAccount2Code? Type { get; init; } 
        #else
        public FundCashAccount2Code? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
        /// </summary>
        [IsoId("_Rzq7Htp-Ed-ak6NoX_4Aeg_-1711849455")]
        [DisplayName("Extended Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="XtndedTp")]
        #endif
        [IsoXmlTag("XtndedTp")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoExtended350Code? ExtendedType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ExtendedType { get; init; } 
        #else
        public System.String? ExtendedType { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
