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
    /// Defines the type of execution to be performed in the request.
    /// </summary>
    [KnownType(typeof(ExecutionType1Choice.Time))]
    [KnownType(typeof(ExecutionType1Choice.Event))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ExecutionType1Choice.Time),nameof(ExecutionType1Choice.Time))]
    [JsonDerivedType(typeof(ExecutionType1Choice.Event),nameof(ExecutionType1Choice.Event))]
    #endif
    [IsoId("_75qQhqMgEeCJ6YNENx4h-w_354040007")]
    [DisplayName("Execution Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExecutionType1Choice_
    #else
    public abstract partial class ExecutionType1Choice_
    #endif
    {
    }
}
