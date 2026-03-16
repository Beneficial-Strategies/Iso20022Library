// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of other asset.
    /// </summary>
    [KnownType(typeof(OtherAsset1Choice.Code))]
    [KnownType(typeof(OtherAsset1Choice.Proprietary))]
    [JsonDerivedType(typeof(OtherAsset1Choice.Code), nameof(OtherAsset1Choice.Code))]
    [JsonDerivedType(typeof(OtherAsset1Choice.Proprietary), nameof(OtherAsset1Choice.Proprietary))]
    [IsoId("_F-8BEEyJEeir2sRRVd9XhA")]
    [DisplayName("Other Asset 1 Choice")]
    public abstract record OtherAsset1Choice_ { }
}
