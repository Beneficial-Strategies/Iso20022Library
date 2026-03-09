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
    /// Planned number of shares to be purchased
    ///  買付予定株式数.
    /// </summary>
    [KnownType(typeof(PlannedQuantity1Choice.Quantity))]
    [KnownType(typeof(PlannedQuantity1Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PlannedQuantity1Choice.Quantity),nameof(PlannedQuantity1Choice.Quantity))]
    [JsonDerivedType(typeof(PlannedQuantity1Choice.Code),nameof(PlannedQuantity1Choice.Code))]
    #endif
    [IsoId("_X3C-0zFzEeGKkIZzgd38VA")]
    [DisplayName("Planned Quantity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PlannedQuantity1Choice_
    #else
    public abstract partial class PlannedQuantity1Choice_
    #endif
    {
    }
}
