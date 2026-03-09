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
namespace BeneficialStrategies.Iso20022.Choices.AirportName1Choice
{
    /// <summary>
    /// Identifies an airport by its location and by its name.
    /// </summary>
    [IsoId("_SsSlJdp-Ed-ak6NoX_4Aeg_-564217545")]
    [DisplayName("Other Airport Description")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OtherAirportDescription : AirportName1Choice_
    #else
    public partial class OtherAirportDescription : AirportName1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OtherAirportDescription instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OtherAirportDescription( System.String reqTown )
        {
            Town = reqTown;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identifies the town where the airport is located. For example: London.
        /// </summary>
        [IsoId("_SsSlIdp-Ed-ak6NoX_4Aeg_-1352905988")]
        [DisplayName("Town")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Twn")]
        #endif
        [IsoXmlTag("Twn")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Town { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Town { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Town { get; init; } 
        #else
        public System.String Town { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the airport by its name. For example: Heathrow.
        /// </summary>
        [IsoId("_SsSlItp-Ed-ak6NoX_4Aeg_-1308575071")]
        [DisplayName("Airport Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AirprtNm")]
        #endif
        [IsoXmlTag("AirprtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? AirportName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AirportName { get; init; } 
        #else
        public System.String? AirportName { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
