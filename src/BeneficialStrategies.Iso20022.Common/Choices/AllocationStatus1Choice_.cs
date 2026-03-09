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
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [KnownType(typeof(AllocationStatus1Choice.FullyAllocated))]
    [KnownType(typeof(AllocationStatus1Choice.PartiallyAllocated))]
    [KnownType(typeof(AllocationStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AllocationStatus1Choice.FullyAllocated),nameof(AllocationStatus1Choice.FullyAllocated))]
    [JsonDerivedType(typeof(AllocationStatus1Choice.PartiallyAllocated),nameof(AllocationStatus1Choice.PartiallyAllocated))]
    [JsonDerivedType(typeof(AllocationStatus1Choice.Proprietary),nameof(AllocationStatus1Choice.Proprietary))]
    #endif
    [IsoId("_D01G0N_-EeiVRbNQx5-Vhg")]
    [DisplayName("Allocation Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AllocationStatus1Choice_
    #else
    public abstract partial class AllocationStatus1Choice_
    #endif
    {
    }
}
