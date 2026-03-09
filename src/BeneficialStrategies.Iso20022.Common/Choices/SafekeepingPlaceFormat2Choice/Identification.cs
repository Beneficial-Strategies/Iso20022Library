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
namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat2Choice
{
    /// <summary>
    /// Place of safekeeping expressed as a code and a narrative description.
    /// </summary>
    [IsoId("_SfVHN9p-Ed-ak6NoX_4Aeg_-2092013261")]
    [DisplayName("Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Identification : SafekeepingPlaceFormat2Choice_
    #else
    public partial class Identification : SafekeepingPlaceFormat2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Identification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Identification( SafekeepingPlace2Code reqSafekeepingPlaceType )
        {
            SafekeepingPlaceType = reqSafekeepingPlaceType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Place of safekeeping as a code.
        /// </summary>
        [IsoId("_SfVHMdp-Ed-ak6NoX_4Aeg_813979454")]
        [DisplayName("Safekeeping Place Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SfkpgPlcTp")]
        #endif
        [IsoXmlTag("SfkpgPlcTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
        #else
        public SafekeepingPlace2Code SafekeepingPlaceType { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the place of safekeeping.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Value { get; init; } 
        #else
        public System.String? Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
