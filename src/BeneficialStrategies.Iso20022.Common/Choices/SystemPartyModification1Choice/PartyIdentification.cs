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
    /// Unique identification to unambiguously identify the party within the system.
    /// </summary>
    [IsoId("_ko4LsO5NEeCisYr99QEiWA_1625094911")]
    [DisplayName("Party Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PartyIdentification : SystemPartyModification1Choice_
    #else
    public partial class PartyIdentification : SystemPartyModification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PartyIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PartyIdentification( System.DateOnly reqValidFrom )
        {
            ValidFrom = reqValidFrom;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Starting date from which the identification is valid.
        /// </summary>
        [IsoId("_knPM8O5NEeCisYr99QEiWA_2146240777")]
        [DisplayName("Valid From")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldFr")]
        #endif
        [IsoXmlTag("VldFr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate ValidFrom { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly ValidFrom { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly ValidFrom { get; init; } 
        #else
        public System.DateOnly ValidFrom { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous way to identify a system party.
        /// </summary>
        [IsoId("_knPM8e5NEeCisYr99QEiWA_-852146574")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoBICFIIdentifier? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Identification { get; init; } 
        #else
        public System.String? Identification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
