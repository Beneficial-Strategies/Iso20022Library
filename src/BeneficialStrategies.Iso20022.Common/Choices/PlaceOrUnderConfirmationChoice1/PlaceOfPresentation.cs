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
namespace BeneficialStrategies.Iso20022.Choices.PlaceOrUnderConfirmationChoice1
{
    /// <summary>
    /// Party to which the presentation is to be made.
    /// </summary>
    [IsoId("_97kuE3ltEeG7BsjMvd1mEw_-1053470050")]
    [DisplayName("Place Of Presentation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PlaceOfPresentation : PlaceOrUnderConfirmationChoice1_
    #else
    public partial class PlaceOfPresentation : PlaceOrUnderConfirmationChoice1_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PlaceOfPresentation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PlaceOfPresentation( ExternalTypeOfParty1Code reqPlace )
        {
            Place = reqPlace;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Place of the presentation.
        /// </summary>
        [IsoId("_97RzJHltEeG7BsjMvd1mEw_-404426889")]
        [DisplayName("Place")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Plc")]
        #endif
        [IsoXmlTag("Plc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExternalTypeOfParty1Code Place { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExternalTypeOfParty1Code Place { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalTypeOfParty1Code Place { get; init; } 
        #else
        public ExternalTypeOfParty1Code Place { get; set; } 
        #endif
        
        /// <summary>
        /// Country where a presentation is to be made.
        /// </summary>
        [IsoId("_97RzJXltEeG7BsjMvd1mEw_392011712")]
        [DisplayName("Country")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Ctry")]
        #endif
        [IsoXmlTag("Ctry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryCode? Country { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? Country { get; init; } 
        #else
        public string? Country { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
