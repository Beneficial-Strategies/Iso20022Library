// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of address.
    /// </summary>
    [KnownType(typeof(AddressType1Choice.Code))]
    [KnownType(typeof(AddressType1Choice.Proprietary))]
    [JsonDerivedType(typeof(AddressType1Choice.Code),nameof(AddressType1Choice.Code))]
    [JsonDerivedType(typeof(AddressType1Choice.Proprietary),nameof(AddressType1Choice.Proprietary))]
    [IsoId("_B0HaACCKEeWJd9HF2tO7BA")]
    [DisplayName("Address Type 1 Choice")]
    public abstract partial record AddressType1Choice_
    {
    }
}
