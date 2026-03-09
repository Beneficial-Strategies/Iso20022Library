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
    /// Choice of formats for a type of drawdown.
    /// </summary>
    [KnownType(typeof(DrawdownType1Choice.Code))]
    [KnownType(typeof(DrawdownType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DrawdownType1Choice.Code),nameof(DrawdownType1Choice.Code))]
    [JsonDerivedType(typeof(DrawdownType1Choice.Proprietary),nameof(DrawdownType1Choice.Proprietary))]
    #endif
    [IsoId("_NHMP4FNdEeijdq8ilaxyOA")]
    [DisplayName("Drawdown Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DrawdownType1Choice_
    #else
    public abstract partial class DrawdownType1Choice_
    #endif
    {
    }
}
