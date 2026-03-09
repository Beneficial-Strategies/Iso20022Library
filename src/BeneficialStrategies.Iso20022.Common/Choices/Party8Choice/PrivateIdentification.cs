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
namespace BeneficialStrategies.Iso20022.Choices.Party8Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a person, eg, passport.
    /// </summary>
    [IsoId("_PXDusdp-Ed-ak6NoX_4Aeg_1498810894")]
    [DisplayName("Private Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PrivateIdentification : Party8Choice_
    #else
    public partial class PrivateIdentification : Party8Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Date and place of birth of a person.
        /// </summary>
        [IsoId("_QENIl9p-Ed-ak6NoX_4Aeg_1634415117")]
        [DisplayName("Date And Place Of Birth")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DtAndPlcOfBirth")]
        #endif
        [IsoXmlTag("DtAndPlcOfBirth")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndPlaceOfBirth? DateAndPlaceOfBirth { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndPlaceOfBirth? DateAndPlaceOfBirth { get; init; } 
        #else
        public DateAndPlaceOfBirth? DateAndPlaceOfBirth { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_QENImNp-Ed-ak6NoX_4Aeg_1634415136")]
        [DisplayName("Other")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Othr")]
        #endif
        [IsoXmlTag("Othr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public GenericPersonIdentification1? Other { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public GenericPersonIdentification1? Other { get; init; } 
        #else
        public GenericPersonIdentification1? Other { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
