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
namespace BeneficialStrategies.Iso20022.Choices.AddressOrParty1Choice
{
    /// <summary>
    /// New beneficiary.
    /// </summary>
    [IsoId("_-Eq_sXltEeG7BsjMvd1mEw_-1059783639")]
    [DisplayName("New Beneficiary")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NewBeneficiary : AddressOrParty1Choice_
    #else
    public partial class NewBeneficiary : AddressOrParty1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NewBeneficiary instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NewBeneficiary( System.String reqName,PostalAddress6 reqAddress )
        {
            Name = reqName;
            Address = reqAddress;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and is usually used to identify that party.
        /// </summary>
        [IsoId("_Pa7iEtp-Ed-ak6NoX_4Aeg_1232531078")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Postal address of a party.
        /// </summary>
        [IsoId("_Pa7iE9p-Ed-ak6NoX_4Aeg_1232531138")]
        [DisplayName("Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Adr")]
        #endif
        [IsoXmlTag("Adr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PostalAddress6 Address { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PostalAddress6 Address { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostalAddress6 Address { get; init; } 
        #else
        public PostalAddress6 Address { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
