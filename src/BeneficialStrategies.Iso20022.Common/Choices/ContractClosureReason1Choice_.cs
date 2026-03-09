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
    /// Reason for the closure of the contract.
    /// </summary>
    [KnownType(typeof(ContractClosureReason1Choice.Code))]
    [KnownType(typeof(ContractClosureReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ContractClosureReason1Choice.Code),nameof(ContractClosureReason1Choice.Code))]
    [JsonDerivedType(typeof(ContractClosureReason1Choice.Proprietary),nameof(ContractClosureReason1Choice.Proprietary))]
    #endif
    [IsoId("_X56BEArAEeWD-cmAqruRjw")]
    [DisplayName("Contract Closure Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ContractClosureReason1Choice_
    #else
    public abstract partial class ContractClosureReason1Choice_
    #endif
    {
    }
}
