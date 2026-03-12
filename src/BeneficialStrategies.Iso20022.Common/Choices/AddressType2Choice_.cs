// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of address.
    /// </summary>
    [KnownType(typeof(AddressType2Choice.Code))]
    [KnownType(typeof(AddressType2Choice.Proprietary))]
    [JsonDerivedType(typeof(AddressType2Choice.Code),nameof(AddressType2Choice.Code))]
    [JsonDerivedType(typeof(AddressType2Choice.Proprietary),nameof(AddressType2Choice.Proprietary))]
    [IsoId("_DfORECFzEeW9XJWqfgXIIA")]
    [DisplayName("Address Type 2 Choice")]
    public abstract partial record AddressType2Choice_
    {
    }
}
