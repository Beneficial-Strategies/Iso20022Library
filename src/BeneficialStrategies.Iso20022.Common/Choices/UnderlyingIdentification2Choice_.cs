// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Details of the underlying of a security transaction.
    /// </summary>
    [KnownType(typeof(UnderlyingIdentification2Choice.Swap))]
    [KnownType(typeof(UnderlyingIdentification2Choice.Other))]
    [JsonDerivedType(
        typeof(UnderlyingIdentification2Choice.Swap),
        nameof(UnderlyingIdentification2Choice.Swap)
    )]
    [JsonDerivedType(
        typeof(UnderlyingIdentification2Choice.Other),
        nameof(UnderlyingIdentification2Choice.Other)
    )]
    [IsoId("_Ko9qBYG-EeaalK9UbuVGFw")]
    [DisplayName("Underlying Identification 2 Choice")]
    public abstract record UnderlyingIdentification2Choice_ { }
}
