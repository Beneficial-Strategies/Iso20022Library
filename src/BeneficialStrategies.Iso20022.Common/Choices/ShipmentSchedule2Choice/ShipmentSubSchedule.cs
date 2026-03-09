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
namespace BeneficialStrategies.Iso20022.Choices.ShipmentSchedule2Choice
{
    /// <summary>
    /// Specifies a shipment schedule, ie, quantity that must be shipped no sooner than the earliest shipment date and no later than the latest shipment date.
    /// </summary>
    [IsoId("_0ZWmk-fHEeKNfc-Rw_dPYg")]
    [DisplayName("Shipment Sub Schedule")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record ShipmentSubSchedule : ShipmentSchedule2Choice_
    #else
    public partial class ShipmentSubSchedule : ShipmentSchedule2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a ShipmentSubSchedule instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public ShipmentSubSchedule( System.UInt64 reqSubQuantityValue )
        {
            SubQuantityValue = reqSubQuantityValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Sub quantity that must be shipped no sooner than the earliest shipment date and no later than the latest shipment date.
        /// </summary>
        [IsoId("_Sp5_htp-Ed-ak6NoX_4Aeg_-1202382015")]
        [DisplayName("Sub Quantity Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SubQtyVal")]
        #endif
        [IsoXmlTag("SubQtyVal")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoDecimalNumber SubQuantityValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 SubQuantityValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 SubQuantityValue { get; init; } 
        #else
        public System.UInt64 SubQuantityValue { get; set; } 
        #endif
        
        /// <summary>
        /// Earliest date whereby the goods must be shipped.
        /// </summary>
        [IsoId("_Sp5_h9p-Ed-ak6NoX_4Aeg_-876378095")]
        [DisplayName("Earliest Shipment Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EarlstShipmntDt")]
        #endif
        [IsoXmlTag("EarlstShipmntDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? EarliestShipmentDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? EarliestShipmentDate { get; init; } 
        #else
        public System.DateOnly? EarliestShipmentDate { get; set; } 
        #endif
        
        /// <summary>
        /// Latest date whereby the goods must be shipped.
        /// </summary>
        [IsoId("_SqDwgNp-Ed-ak6NoX_4Aeg_-1202381938")]
        [DisplayName("Latest Shipment Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LatstShipmntDt")]
        #endif
        [IsoXmlTag("LatstShipmntDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? LatestShipmentDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? LatestShipmentDate { get; init; } 
        #else
        public System.DateOnly? LatestShipmentDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
