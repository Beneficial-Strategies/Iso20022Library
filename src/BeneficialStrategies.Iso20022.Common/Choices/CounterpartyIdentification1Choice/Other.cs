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
namespace BeneficialStrategies.Iso20022.Choices.CounterpartyIdentification1Choice
{
    /// <summary>
    /// Other identification of the counterparty through the sector and the location.
    /// </summary>
    [IsoId("__jASAZfcEeSfnc-VXAEapg")]
    [DisplayName("Other")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Other : CounterpartyIdentification1Choice_
    #else
    public partial class Other : CounterpartyIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Other instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Other( System.String reqSector,string reqLocation )
        {
            Sector = reqSector;
            Location = reqLocation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Represents the counterparty institutional section (such as non-financial corporation, central bank.).
        /// </summary>
        [IsoId("_oLh_0JfdEeSfnc-VXAEapg")]
        [DisplayName("Sector")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sctr")]
        #endif
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoSNA2008SectorIdentifier Sector { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Sector { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Sector { get; init; } 
        #else
        public System.String Sector { get; set; } 
        #endif
        
        /// <summary>
        /// Location of the country in which the counterparty is incorporated.
        /// </summary>
        [IsoId("_97X68JfeEeSfnc-VXAEapg")]
        [DisplayName("Location")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Lctn")]
        #endif
        [IsoXmlTag("Lctn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CountryCode Location { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string Location { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string Location { get; init; } 
        #else
        public string Location { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
