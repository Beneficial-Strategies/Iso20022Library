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
    /// Choice of format for the auto extend period.
    /// </summary>
    [KnownType(typeof(AutoExtend1Choice.Days))]
    [KnownType(typeof(AutoExtend1Choice.Months))]
    [KnownType(typeof(AutoExtend1Choice.Years))]
    [KnownType(typeof(AutoExtend1Choice.Date))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AutoExtend1Choice.Days),nameof(AutoExtend1Choice.Days))]
    [JsonDerivedType(typeof(AutoExtend1Choice.Months),nameof(AutoExtend1Choice.Months))]
    [JsonDerivedType(typeof(AutoExtend1Choice.Years),nameof(AutoExtend1Choice.Years))]
    [JsonDerivedType(typeof(AutoExtend1Choice.Date),nameof(AutoExtend1Choice.Date))]
    #endif
    [IsoId("_95V5enltEeG7BsjMvd1mEw_-1540173231")]
    [DisplayName("Auto Extend 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AutoExtend1Choice_
    #else
    public abstract partial class AutoExtend1Choice_
    #endif
    {
    }
}
