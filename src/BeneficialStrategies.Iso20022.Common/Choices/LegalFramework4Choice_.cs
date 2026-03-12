// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the legal framework.
    /// </summary>
    [KnownType(typeof(LegalFramework4Choice.Code))]
    [KnownType(typeof(LegalFramework4Choice.Proprietary))]
    [JsonDerivedType(typeof(LegalFramework4Choice.Code),nameof(LegalFramework4Choice.Code))]
    [JsonDerivedType(typeof(LegalFramework4Choice.Proprietary),nameof(LegalFramework4Choice.Proprietary))]
    [IsoId("_5mw4H5NLEeWGlc8L7oPDIg")]
    [DisplayName("Legal Framework 4 Choice")]
    public abstract partial record LegalFramework4Choice_
    {
    }
}
