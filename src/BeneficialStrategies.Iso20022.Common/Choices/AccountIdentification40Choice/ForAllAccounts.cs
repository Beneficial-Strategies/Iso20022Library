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
namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification40Choice
{
    /// <summary>
    /// All safekeeping accounts that own underlying financial instrument.
    /// </summary>
    [IsoId("_Z0GPA7XDEeiTob_PrFFUxA")]
    [DisplayName("For All Accounts")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ForAllAccounts : AccountIdentification40Choice_
    #else
    public partial class ForAllAccounts : AccountIdentification40Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ForAllAccounts instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ForAllAccounts( SafekeepingAccountIdentification1Code reqIdentificationCode )
        {
            IdentificationCode = reqIdentificationCode;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Standard code to specify that announcement applies to all safekeeping accounts that own underlying financial instrument.
        /// </summary>
        [IsoId("_QSgqVNp-Ed-ak6NoX_4Aeg_-758816150")]
        [DisplayName("Identification Code")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IdCd")]
        #endif
        [IsoXmlTag("IdCd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SafekeepingAccountIdentification1Code IdentificationCode { get; init; } 
        #else
        public SafekeepingAccountIdentification1Code IdentificationCode { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
