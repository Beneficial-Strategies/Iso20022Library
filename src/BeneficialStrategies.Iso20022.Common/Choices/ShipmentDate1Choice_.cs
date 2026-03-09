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
    /// Choice between proposed and actual shipment date.
    /// </summary>
    [KnownType(typeof(ShipmentDate1Choice.ProposedShipmentDate))]
    [KnownType(typeof(ShipmentDate1Choice.ActualShipmentDate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ShipmentDate1Choice.ProposedShipmentDate),nameof(ShipmentDate1Choice.ProposedShipmentDate))]
    [JsonDerivedType(typeof(ShipmentDate1Choice.ActualShipmentDate),nameof(ShipmentDate1Choice.ActualShipmentDate))]
    #endif
    [IsoId("_qi4msDATEeOKib24wnHaFg")]
    [DisplayName("Shipment Date 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ShipmentDate1Choice_
    #else
    public abstract partial class ShipmentDate1Choice_
    #endif
    {
    }
}
