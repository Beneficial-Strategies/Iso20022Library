// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransportMeans1Choice
{
    /// <summary>
    /// Moving of goods or people from one place to another by vehicle.
    /// </summary>
    [IsoId("_U7oxldp-Ed-ak6NoX_4Aeg_1658534673")]
    [DisplayName("Individual Transport")]
    public partial record IndividualTransport : TransportMeans1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Moving of goods or people from one place to another by vehicle.
        /// </summary>
        [IsoId("_U7fnoNp-Ed-ak6NoX_4Aeg_2015935953")]
        [DisplayName("Transport By Air")]
        [IsoXmlTag("TrnsprtByAir")]
        public TransportByAir1? TransportByAir { get; init; } 
        
        /// <summary>
        /// Information related for the transportation of goods by sea.
        /// </summary>
        [IsoId("_U7fnodp-Ed-ak6NoX_4Aeg_2030713576")]
        [DisplayName("Transport By Sea")]
        [IsoXmlTag("TrnsprtBySea")]
        public TransportBySea1? TransportBySea { get; init; } 
        
        /// <summary>
        /// Information related to the transportation of goods by road.
        /// </summary>
        [IsoId("_U7fnotp-Ed-ak6NoX_4Aeg_2027019443")]
        [DisplayName("Transport By Road")]
        [IsoXmlTag("TrnsprtByRoad")]
        public TransportByRoad1? TransportByRoad { get; init; } 
        
        /// <summary>
        /// Information related to the transportation of goods by rail.
        /// </summary>
        [IsoId("_U7fno9p-Ed-ak6NoX_4Aeg_2035329660")]
        [DisplayName("Transport By Rail")]
        [IsoXmlTag("TrnsprtByRail")]
        public TransportByRail1? TransportByRail { get; init; } 
        
        
        #nullable disable
        
    }
}
