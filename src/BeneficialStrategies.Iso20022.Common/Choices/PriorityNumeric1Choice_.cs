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
    /// Choice of format for the priority.
    /// </summary>
    [KnownType(typeof(PriorityNumeric1Choice.Numeric))]
    [KnownType(typeof(PriorityNumeric1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriorityNumeric1Choice.Numeric),nameof(PriorityNumeric1Choice.Numeric))]
    [JsonDerivedType(typeof(PriorityNumeric1Choice.Proprietary),nameof(PriorityNumeric1Choice.Proprietary))]
    #endif
    [IsoId("_QuYG8Np-Ed-ak6NoX_4Aeg_827565267")]
    [DisplayName("Priority Numeric 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriorityNumeric1Choice_
    #else
    public abstract partial class PriorityNumeric1Choice_
    #endif
    {
    }
}
