// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate6Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate6Choice.OriginalMandate))]
    [JsonDerivedType(typeof(OriginalMandate6Choice.OriginalMandateIdentification),nameof(OriginalMandate6Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate6Choice.OriginalMandate),nameof(OriginalMandate6Choice.OriginalMandate))]
    [IsoId("_Hfkt2W49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate 6 Choice")]
    public abstract partial record OriginalMandate6Choice_
    {
    }
}
