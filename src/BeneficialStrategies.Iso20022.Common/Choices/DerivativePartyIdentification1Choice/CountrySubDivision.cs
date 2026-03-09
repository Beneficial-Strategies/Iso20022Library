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
namespace BeneficialStrategies.Iso20022.Choices.DerivativePartyIdentification1Choice
{
    /// <summary>
    /// Country and country sub-division of the reference entity.
    /// </summary>
    [IsoId("_sN3rEEW8EeWaZZ6gWK8UVw")]
    [DisplayName("Country Sub Division")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CountrySubDivision : DerivativePartyIdentification1Choice_
    #else
    public partial class CountrySubDivision : DerivativePartyIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CountrySubDivision instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CountrySubDivision( string reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Code to identify a name of a unit resulting from the division of a country, dependency, or other area of special geopolitical interest contained in ISO 3166-1, on the basis of country names obtained from the United Nations (ISO 3166-2: Country subdivision code).
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrySubDvsn")]
        #endif
        [IsoXmlTag("CtrySubDvsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CountrySubDivisionCode Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string Value { get; init; } 
        #else
        public string Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
