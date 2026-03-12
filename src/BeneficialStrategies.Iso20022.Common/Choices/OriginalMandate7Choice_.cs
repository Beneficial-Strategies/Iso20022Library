// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate7Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate7Choice.OriginalMandate))]
    [JsonDerivedType(typeof(OriginalMandate7Choice.OriginalMandateIdentification),nameof(OriginalMandate7Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate7Choice.OriginalMandate),nameof(OriginalMandate7Choice.OriginalMandate))]
    [IsoId("_ZyBKfW49EeiU9cctagi5ow")]
    [DisplayName("Original Mandate 7 Choice")]
    public abstract partial record OriginalMandate7Choice_
    {
    }
}
