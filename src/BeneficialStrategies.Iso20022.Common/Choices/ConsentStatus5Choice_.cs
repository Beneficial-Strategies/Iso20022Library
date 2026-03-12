// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of consent status.
    /// </summary>
    [KnownType(typeof(ConsentStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(ConsentStatus5Choice.Reason))]
    [JsonDerivedType(typeof(ConsentStatus5Choice.NoSpecifiedReason),nameof(ConsentStatus5Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ConsentStatus5Choice.Reason),nameof(ConsentStatus5Choice.Reason))]
    [IsoId("_Vl2wL5NSEeWGlc8L7oPDIg")]
    [DisplayName("Consent Status 5 Choice")]
    public abstract partial record ConsentStatus5Choice_
    {
    }
}
