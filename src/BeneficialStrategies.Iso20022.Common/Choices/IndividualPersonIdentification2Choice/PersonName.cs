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
namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentification2Choice
{
    /// <summary>
    /// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
    /// </summary>
    [IsoId("_6KMwsyGZEeWKAaDJcYGKLw")]
    [DisplayName("Person Name")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PersonName : IndividualPersonIdentification2Choice_
    #else
    public partial class PersonName : IndividualPersonIdentification2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PersonName instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PersonName( System.String reqName )
        {
            Name = reqName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// First name of the person.
        /// </summary>
        [IsoId("_1X2C0V0fEeWFBqZ9f7Sd_g")]
        [DisplayName("Given Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="GvnNm")]
        #endif
        [IsoXmlTag("GvnNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? GivenName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? GivenName { get; init; } 
        #else
        public System.String? GivenName { get; set; } 
        #endif
        
        /// <summary>
        /// Second name of the person.
        /// </summary>
        [IsoId("_1X2C010fEeWFBqZ9f7Sd_g")]
        [DisplayName("Middle Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MddlNm")]
        #endif
        [IsoXmlTag("MddlNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? MiddleName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? MiddleName { get; init; } 
        #else
        public System.String? MiddleName { get; set; } 
        #endif
        
        /// <summary>
        /// Name by which the party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_1X2C1V0fEeWFBqZ9f7Sd_g")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax350Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Gender of the person.
        /// </summary>
        [IsoId("_1X2C110fEeWFBqZ9f7Sd_g")]
        [DisplayName("Gender")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Gndr")]
        #endif
        [IsoXmlTag("Gndr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenderCode? Gender { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenderCode? Gender { get; init; } 
        #else
        public GenderCode? Gender { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the person is born.
        /// </summary>
        [IsoId("_1X2C2V0fEeWFBqZ9f7Sd_g")]
        [DisplayName("Birth Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BirthDt")]
        #endif
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? BirthDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? BirthDate { get; init; } 
        #else
        public System.DateOnly? BirthDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
