// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a transfer type.
    /// </summary>
    [KnownType(typeof(TransferType1Choice.Code))]
    [KnownType(typeof(TransferType1Choice.Proprietary))]
    [JsonDerivedType(typeof(TransferType1Choice.Code),nameof(TransferType1Choice.Code))]
    [JsonDerivedType(typeof(TransferType1Choice.Proprietary),nameof(TransferType1Choice.Proprietary))]
    [IsoId("_WBlccE3VEeidB49bWZiS0g")]
    [DisplayName("Transfer Type 1 Choice")]
    public abstract partial record TransferType1Choice_
    {
    }
}
