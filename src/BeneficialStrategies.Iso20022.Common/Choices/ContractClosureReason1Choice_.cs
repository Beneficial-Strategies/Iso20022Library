// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the closure of the contract.
    /// </summary>
    [KnownType(typeof(ContractClosureReason1Choice.Code))]
    [KnownType(typeof(ContractClosureReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ContractClosureReason1Choice.Code),nameof(ContractClosureReason1Choice.Code))]
    [JsonDerivedType(typeof(ContractClosureReason1Choice.Proprietary),nameof(ContractClosureReason1Choice.Proprietary))]
    [IsoId("_X56BEArAEeWD-cmAqruRjw")]
    [DisplayName("Contract Closure Reason 1 Choice")]
    public abstract partial record ContractClosureReason1Choice_
    {
    }
}
