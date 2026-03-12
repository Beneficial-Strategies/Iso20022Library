// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate2Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate2Choice.OriginalMandate))]
    [JsonDerivedType(typeof(OriginalMandate2Choice.OriginalMandateIdentification),nameof(OriginalMandate2Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate2Choice.OriginalMandate),nameof(OriginalMandate2Choice.OriginalMandate))]
    [IsoId("_to8xYVkyEeGeoaLUQk__nA_-1304460970")]
    [DisplayName("Original Mandate 2 Choice")]
    public abstract partial record OriginalMandate2Choice_
    {
    }
}
