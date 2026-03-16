// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the legal framework.
    /// </summary>
    [KnownType(typeof(LegalFramework1Choice.Code))]
    [KnownType(typeof(LegalFramework1Choice.Proprietary))]
    [JsonDerivedType(typeof(LegalFramework1Choice.Code), nameof(LegalFramework1Choice.Code))]
    [JsonDerivedType(
        typeof(LegalFramework1Choice.Proprietary),
        nameof(LegalFramework1Choice.Proprietary)
    )]
    [IsoId("_QuYG9tp-Ed-ak6NoX_4Aeg_-359745650")]
    [DisplayName("Legal Framework 1 Choice")]
    public abstract record LegalFramework1Choice_ { }
}
