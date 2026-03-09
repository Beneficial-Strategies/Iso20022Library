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
    /// Choice of format for the undertaking termination reason.
    /// </summary>
    [KnownType(typeof(TerminationReason1Choice.Code))]
    [KnownType(typeof(TerminationReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TerminationReason1Choice.Code),nameof(TerminationReason1Choice.Code))]
    [JsonDerivedType(typeof(TerminationReason1Choice.Proprietary),nameof(TerminationReason1Choice.Proprietary))]
    #endif
    [IsoId("_932rsXltEeG7BsjMvd1mEw_1357060754")]
    [DisplayName("Termination Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TerminationReason1Choice_
    #else
    public abstract partial class TerminationReason1Choice_
    #endif
    {
    }
}
