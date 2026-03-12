// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indication whether a derivative contract is tranched.
    /// </summary>
    [KnownType(typeof(TrancheIndicator3Choice.Tranched))]
    [KnownType(typeof(TrancheIndicator3Choice.Untranched))]
    [JsonDerivedType(typeof(TrancheIndicator3Choice.Tranched),nameof(TrancheIndicator3Choice.Tranched))]
    [JsonDerivedType(typeof(TrancheIndicator3Choice.Untranched),nameof(TrancheIndicator3Choice.Untranched))]
    [IsoId("_mq05QQ06EeuJ1fOEB4bQXA")]
    [DisplayName("Tranche Indicator 3 Choice")]
    public abstract partial record TrancheIndicator3Choice_
    {
    }
}
