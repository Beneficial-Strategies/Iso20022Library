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
namespace BeneficialStrategies.Iso20022.Choices.TransportMeans1Choice
{
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_U7oxldp-Ed-ak6NoX_4Aeg_1658534673")]
    [DisplayName("Individual Transport")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IndividualTransport : TransportMeans1Choice_
    #else
    public partial class IndividualTransport : TransportMeans1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Moving of goods or people from one place to another by vehicle.
        /// </summary>
        [IsoId("_U7fnoNp-Ed-ak6NoX_4Aeg_2015935953")]
        [DisplayName("Transport By Air")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrnsprtByAir")]
        #endif
        [IsoXmlTag("TrnsprtByAir")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransportByAir1? TransportByAir { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransportByAir1? TransportByAir { get; init; } 
        #else
        public TransportByAir1? TransportByAir { get; set; } 
        #endif
        
        /// <summary>
        /// Information related for the transportation of goods by sea.
        /// </summary>
        [IsoId("_U7fnodp-Ed-ak6NoX_4Aeg_2030713576")]
        [DisplayName("Transport By Sea")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrnsprtBySea")]
        #endif
        [IsoXmlTag("TrnsprtBySea")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransportBySea1? TransportBySea { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransportBySea1? TransportBySea { get; init; } 
        #else
        public TransportBySea1? TransportBySea { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to the transportation of goods by road.
        /// </summary>
        [IsoId("_U7fnotp-Ed-ak6NoX_4Aeg_2027019443")]
        [DisplayName("Transport By Road")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrnsprtByRoad")]
        #endif
        [IsoXmlTag("TrnsprtByRoad")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransportByRoad1? TransportByRoad { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransportByRoad1? TransportByRoad { get; init; } 
        #else
        public TransportByRoad1? TransportByRoad { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to the transportation of goods by rail.
        /// </summary>
        [IsoId("_U7fno9p-Ed-ak6NoX_4Aeg_2035329660")]
        [DisplayName("Transport By Rail")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TrnsprtByRail")]
        #endif
        [IsoXmlTag("TrnsprtByRail")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransportByRail1? TransportByRail { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransportByRail1? TransportByRail { get; init; } 
        #else
        public TransportByRail1? TransportByRail { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
