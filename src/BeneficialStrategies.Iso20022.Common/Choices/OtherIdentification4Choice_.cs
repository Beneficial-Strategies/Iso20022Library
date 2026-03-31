// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of other identification.
    /// </summary>
    [KnownType(typeof(OtherIdentification4Choice.Code))]
    [KnownType(typeof(OtherIdentification4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(OtherIdentification4Choice.Code),
        nameof(OtherIdentification4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(OtherIdentification4Choice.Proprietary),
        nameof(OtherIdentification4Choice.Proprietary)
    )]
    [IsoId("_S_Cxr0HLEeWeNKJ6kJGSFw")]
    [DisplayName("Other Identification 4 Choice")]
    public abstract record OtherIdentification4Choice_ { }
}
