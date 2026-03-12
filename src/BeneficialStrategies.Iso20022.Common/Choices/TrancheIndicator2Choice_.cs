// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indication whether a derivative contract is tranched.
    /// </summary>
    [KnownType(typeof(TrancheIndicator2Choice.Tranched))]
    [KnownType(typeof(TrancheIndicator2Choice.Untranched))]
    [JsonDerivedType(typeof(TrancheIndicator2Choice.Tranched),nameof(TrancheIndicator2Choice.Tranched))]
    [JsonDerivedType(typeof(TrancheIndicator2Choice.Untranched),nameof(TrancheIndicator2Choice.Untranched))]
    [IsoId("_5tB9YbyOEeaUov4jN5X9Qw")]
    [DisplayName("Tranche Indicator 2 Choice")]
    public abstract partial record TrancheIndicator2Choice_
    {
    }
}
