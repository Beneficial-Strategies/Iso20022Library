// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Bid Range Type2Choice.
    /// </summary>
    [KnownType(typeof(BidRangeType2Choice.Code))]
    [KnownType(typeof(BidRangeType2Choice.Proprietary))]
    [JsonDerivedType(typeof(BidRangeType2Choice.Code),nameof(BidRangeType2Choice.Code))]
    [JsonDerivedType(typeof(BidRangeType2Choice.Proprietary),nameof(BidRangeType2Choice.Proprietary))]
    [IsoId("_Qn8A0aAdEe-6zfgb2Rwrlw")]
    [DisplayName("Bid Range Type2Choice")]
    public abstract partial record BidRangeType2Choice_
    {
    }
}
