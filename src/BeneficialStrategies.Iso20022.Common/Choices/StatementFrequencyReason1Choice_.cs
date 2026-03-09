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
    /// Choice of formats for the specification of the statement frequency.
    /// </summary>
    [KnownType(typeof(StatementFrequencyReason1Choice.Code))]
    [KnownType(typeof(StatementFrequencyReason1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatementFrequencyReason1Choice.Code),nameof(StatementFrequencyReason1Choice.Code))]
    [JsonDerivedType(typeof(StatementFrequencyReason1Choice.Proprietary),nameof(StatementFrequencyReason1Choice.Proprietary))]
    #endif
    [IsoId("_gGvAoxc_EeK5g-3oYI0_9Q")]
    [DisplayName("Statement Frequency Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatementFrequencyReason1Choice_
    #else
    public abstract partial class StatementFrequencyReason1Choice_
    #endif
    {
    }
}
