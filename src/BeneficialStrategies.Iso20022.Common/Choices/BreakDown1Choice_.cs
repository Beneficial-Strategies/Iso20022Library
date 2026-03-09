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
    /// Specifies if breakdown is by purchase order or commercial invoice.
    /// </summary>
    [KnownType(typeof(BreakDown1Choice.ByPurchaseOrder))]
    [KnownType(typeof(BreakDown1Choice.ByCommercialInvoice))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BreakDown1Choice.ByPurchaseOrder),nameof(BreakDown1Choice.ByPurchaseOrder))]
    [JsonDerivedType(typeof(BreakDown1Choice.ByCommercialInvoice),nameof(BreakDown1Choice.ByCommercialInvoice))]
    #endif
    [IsoId("_tbfaMBrYEeOVR9VN6fAMUg")]
    [DisplayName("Break Down 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BreakDown1Choice_
    #else
    public abstract partial class BreakDown1Choice_
    #endif
    {
    }
}
