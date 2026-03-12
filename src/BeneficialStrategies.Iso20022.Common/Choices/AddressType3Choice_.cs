// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of address.
    /// </summary>
    [KnownType(typeof(AddressType3Choice.Code))]
    [KnownType(typeof(AddressType3Choice.Proprietary))]
    [JsonDerivedType(typeof(AddressType3Choice.Code),nameof(AddressType3Choice.Code))]
    [JsonDerivedType(typeof(AddressType3Choice.Proprietary),nameof(AddressType3Choice.Proprietary))]
    [IsoId("_CneugRb-EeiyVv5j1vf1VQ")]
    [DisplayName("Address Type 3 Choice")]
    public abstract partial record AddressType3Choice_
    {
    }
}
