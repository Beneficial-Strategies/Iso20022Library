// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of consent status.
    /// </summary>
    [KnownType(typeof(ConsentStatus2Choice.NoSpecifiedReason))]
    [KnownType(typeof(ConsentStatus2Choice.Reason))]
    [JsonDerivedType(typeof(ConsentStatus2Choice.NoSpecifiedReason),nameof(ConsentStatus2Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ConsentStatus2Choice.Reason),nameof(ConsentStatus2Choice.Reason))]
    [IsoId("_0jhc8QlIEeGATtfOBToyew_-1079502867")]
    [DisplayName("Consent Status 2 Choice")]
    public abstract partial record ConsentStatus2Choice_
    {
    }
}
