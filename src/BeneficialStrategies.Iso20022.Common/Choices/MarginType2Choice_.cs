// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of margin, for example, initial margin, variation margin, initial deposit or coupon margin.
    /// </summary>
    [KnownType(typeof(MarginType2Choice.Code))]
    [KnownType(typeof(MarginType2Choice.Proprietary))]
    [JsonDerivedType(typeof(MarginType2Choice.Code),nameof(MarginType2Choice.Code))]
    [JsonDerivedType(typeof(MarginType2Choice.Proprietary),nameof(MarginType2Choice.Proprietary))]
    [IsoId("_JT728I1rEeet3cKIYK84nw")]
    [DisplayName("Margin Type 2 Choice")]
    public abstract partial record MarginType2Choice_
    {
    }
}
