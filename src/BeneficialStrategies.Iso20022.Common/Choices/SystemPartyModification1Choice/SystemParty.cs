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
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyModification1Choice
{
    /// <summary>
    /// Specifies the party reference data, as assigned by the system.
    /// </summary>
    [IsoId("_kouatO5NEeCisYr99QEiWA_769363521")]
    [DisplayName("System Party")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SystemParty : SystemPartyModification1Choice_
    #else
    public partial class SystemParty : SystemPartyModification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the opening date of the party.
        /// </summary>
        [IsoId("_kmC6Iu5NEeCisYr99QEiWA_1131494895")]
        [DisplayName("Opening Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OpngDt")]
        #endif
        [IsoXmlTag("OpngDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? OpeningDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? OpeningDate { get; init; } 
        #else
        public System.DateOnly? OpeningDate { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the closing date of the party.
        /// </summary>
        [IsoId("_kmC6I-5NEeCisYr99QEiWA_-586504225")]
        [DisplayName("Closing Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClsgDt")]
        #endif
        [IsoXmlTag("ClsgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ClosingDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ClosingDate { get; init; } 
        #else
        public System.DateOnly? ClosingDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
