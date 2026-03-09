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
namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation2Choice
{
    /// <summary>
    /// Identification of a person.
    /// </summary>
    [IsoId("_-GX-RQkiEeWGouz230Xp5Q")]
    [DisplayName("Person")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Person : PersonOrOrganisation2Choice_
    #else
    public partial class Person : PersonOrOrganisation2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Person instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Person( System.String reqFirstName,System.String reqName,System.DateOnly reqBirthDate,GenericPersonIdentification1 reqOther )
        {
            FirstName = reqFirstName;
            Name = reqName;
            BirthDate = reqBirthDate;
            Other = reqOther;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// First name of a person (also known as given name).
        /// </summary>
        [IsoId("_AifA0vPZEeS_qLctCs2aRQ")]
        [DisplayName("First Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FrstNm")]
        #endif
        [IsoXmlTag("FrstNm")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax140Text FirstName { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String FirstName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String FirstName { get; init; } 
        #else
        public System.String FirstName { get; set; } 
        #endif
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_AifA0_PZEeS_qLctCs2aRQ")]
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
        /// Date on which a person is born.
        /// </summary>
        [IsoId("_BzRTQfPZEeS_qLctCs2aRQ")]
        [DisplayName("Birth Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BirthDt")]
        #endif
        [IsoXmlTag("BirthDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate BirthDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly BirthDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly BirthDate { get; init; } 
        #else
        public System.DateOnly BirthDate { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_98J3xfPYEeS_qLctCs2aRQ")]
        [DisplayName("Other")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Othr")]
        #endif
        [IsoXmlTag("Othr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required GenericPersonIdentification1 Other { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required GenericPersonIdentification1 Other { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericPersonIdentification1 Other { get; init; } 
        #else
        public GenericPersonIdentification1 Other { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
