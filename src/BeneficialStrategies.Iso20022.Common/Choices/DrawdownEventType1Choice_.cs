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
    /// Choice of formats for a drawdown event type.
    /// </summary>
    [KnownType(typeof(DrawdownEventType1Choice.Code))]
    [KnownType(typeof(DrawdownEventType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DrawdownEventType1Choice.Code),nameof(DrawdownEventType1Choice.Code))]
    [JsonDerivedType(typeof(DrawdownEventType1Choice.Proprietary),nameof(DrawdownEventType1Choice.Proprietary))]
    #endif
    [IsoId("_DvIiEFNiEeijdq8ilaxyOA")]
    [DisplayName("Drawdown Event Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DrawdownEventType1Choice_
    #else
    public abstract partial class DrawdownEventType1Choice_
    #endif
    {
    }
}
