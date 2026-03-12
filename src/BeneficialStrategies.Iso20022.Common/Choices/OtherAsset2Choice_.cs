// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of other asset.
    /// </summary>
    [KnownType(typeof(OtherAsset2Choice.Code))]
    [KnownType(typeof(OtherAsset2Choice.Proprietary))]
    [JsonDerivedType(typeof(OtherAsset2Choice.Code),nameof(OtherAsset2Choice.Code))]
    [JsonDerivedType(typeof(OtherAsset2Choice.Proprietary),nameof(OtherAsset2Choice.Proprietary))]
    [IsoId("_-9ZlgZNBEemQB_8XA98K0Q")]
    [DisplayName("Other Asset 2 Choice")]
    public abstract partial record OtherAsset2Choice_
    {
    }
}
