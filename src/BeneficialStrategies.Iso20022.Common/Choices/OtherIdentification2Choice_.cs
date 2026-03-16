// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of other identification.
    /// </summary>
    [KnownType(typeof(OtherIdentification2Choice.Code))]
    [KnownType(typeof(OtherIdentification2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OtherIdentification2Choice.Code),
        nameof(OtherIdentification2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OtherIdentification2Choice.Proprietary),
        nameof(OtherIdentification2Choice.Proprietary)
    )]
    [IsoId("_3xLNoQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Other Identification 2 Choice")]
    public abstract record OtherIdentification2Choice_ { }
}
