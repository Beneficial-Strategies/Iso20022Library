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
    /// Choice of formats for the specification of the type of transaction Channel.
    /// </summary>
    [KnownType(typeof(TransactionChannelType1Choice.Code))]
    [KnownType(typeof(TransactionChannelType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TransactionChannelType1Choice.Code),nameof(TransactionChannelType1Choice.Code))]
    [JsonDerivedType(typeof(TransactionChannelType1Choice.Proprietary),nameof(TransactionChannelType1Choice.Proprietary))]
    #endif
    [IsoId("_JtX4MRRGEeOKWo1NF21OVw")]
    [DisplayName("Transaction Channel Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TransactionChannelType1Choice_
    #else
    public abstract partial class TransactionChannelType1Choice_
    #endif
    {
    }
}
