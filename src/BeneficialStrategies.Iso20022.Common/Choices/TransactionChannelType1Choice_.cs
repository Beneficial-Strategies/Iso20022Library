// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the type of transaction Channel.
    /// </summary>
    [KnownType(typeof(TransactionChannelType1Choice.Code))]
    [KnownType(typeof(TransactionChannelType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TransactionChannelType1Choice.Code),nameof(TransactionChannelType1Choice.Code))]
    [JsonDerivedType(typeof(TransactionChannelType1Choice.Proprietary),nameof(TransactionChannelType1Choice.Proprietary))]
    [IsoId("_JtX4MRRGEeOKWo1NF21OVw")]
    [DisplayName("Transaction Channel Type 1 Choice")]
    public abstract partial record TransactionChannelType1Choice_
    {
    }
}
