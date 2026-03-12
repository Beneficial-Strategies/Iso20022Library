// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate8Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate8Choice.OriginalMandate))]
    [JsonDerivedType(typeof(OriginalMandate8Choice.OriginalMandateIdentification),nameof(OriginalMandate8Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate8Choice.OriginalMandate),nameof(OriginalMandate8Choice.OriginalMandate))]
    [IsoId("_bPcdsdcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate 8 Choice")]
    public abstract partial record OriginalMandate8Choice_
    {
    }
}
