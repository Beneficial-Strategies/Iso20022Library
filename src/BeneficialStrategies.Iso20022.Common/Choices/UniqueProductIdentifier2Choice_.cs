// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a standard identifier and a proprietary code.
    /// </summary>
    [KnownType(typeof(UniqueProductIdentifier2Choice.Identification))]
    [KnownType(typeof(UniqueProductIdentifier2Choice.Proprietary))]
    [JsonDerivedType(typeof(UniqueProductIdentifier2Choice.Identification),nameof(UniqueProductIdentifier2Choice.Identification))]
    [JsonDerivedType(typeof(UniqueProductIdentifier2Choice.Proprietary),nameof(UniqueProductIdentifier2Choice.Proprietary))]
    [IsoId("__zlGkWETEe2P-L9DBerEgA")]
    [DisplayName("Unique Product Identifier 2 Choice")]
    public abstract partial record UniqueProductIdentifier2Choice_
    {
    }
}
