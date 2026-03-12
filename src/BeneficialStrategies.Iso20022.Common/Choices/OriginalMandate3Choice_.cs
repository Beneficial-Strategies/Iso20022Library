// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate3Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate3Choice.OriginalMandate))]
    [JsonDerivedType(typeof(OriginalMandate3Choice.OriginalMandateIdentification),nameof(OriginalMandate3Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate3Choice.OriginalMandate),nameof(OriginalMandate3Choice.OriginalMandate))]
    [IsoId("_YThGLR77EeSxevWRRWxNAg")]
    [DisplayName("Original Mandate 3 Choice")]
    public abstract partial record OriginalMandate3Choice_
    {
    }
}
