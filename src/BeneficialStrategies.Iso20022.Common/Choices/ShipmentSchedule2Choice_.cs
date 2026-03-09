// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between earliest/latest shipment date and a shipment schedule per sub quantity of line item quantity.
    /// </summary>
    [KnownType(typeof(ShipmentSchedule2Choice.ShipmentDateRange))]
    [KnownType(typeof(ShipmentSchedule2Choice.ShipmentSubSchedule))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ShipmentSchedule2Choice.ShipmentDateRange),nameof(ShipmentSchedule2Choice.ShipmentDateRange))]
    [JsonDerivedType(typeof(ShipmentSchedule2Choice.ShipmentSubSchedule),nameof(ShipmentSchedule2Choice.ShipmentSubSchedule))]
    #endif
    [IsoId("_z9WAAefHEeKNfc-Rw_dPYg")]
    [DisplayName("Shipment Schedule 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ShipmentSchedule2Choice_
    #else
    public abstract partial class ShipmentSchedule2Choice_
    #endif
    {
    }
}
