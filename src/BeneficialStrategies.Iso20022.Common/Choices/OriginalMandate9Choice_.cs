// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate9Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate9Choice.OriginalMandate))]
    [JsonDerivedType(typeof(OriginalMandate9Choice.OriginalMandateIdentification),nameof(OriginalMandate9Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate9Choice.OriginalMandate),nameof(OriginalMandate9Choice.OriginalMandate))]
    [IsoId("_d_uM-9cZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate 9 Choice")]
    public abstract partial record OriginalMandate9Choice_
    {
    }
}
