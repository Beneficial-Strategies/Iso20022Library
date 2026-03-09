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
    /// Choice of formats for a drawdown status.
    /// </summary>
    [KnownType(typeof(DrawdownStatus1Choice.Code))]
    [KnownType(typeof(DrawdownStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DrawdownStatus1Choice.Code),nameof(DrawdownStatus1Choice.Code))]
    [JsonDerivedType(typeof(DrawdownStatus1Choice.Proprietary),nameof(DrawdownStatus1Choice.Proprietary))]
    #endif
    [IsoId("_bM0XwFKiEeiSDqv62fL07g")]
    [DisplayName("Drawdown Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DrawdownStatus1Choice_
    #else
    public abstract partial class DrawdownStatus1Choice_
    #endif
    {
    }
}
