// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of tax identification.
    /// </summary>
    [KnownType(typeof(TaxIdentificationType1Choice.Code))]
    [KnownType(typeof(TaxIdentificationType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(TaxIdentificationType1Choice.Code),
        nameof(TaxIdentificationType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(TaxIdentificationType1Choice.Proprietary),
        nameof(TaxIdentificationType1Choice.Proprietary)
    )]
    [IsoId("_yWmpEAhIEeSUPbC7DbLJpQ")]
    [DisplayName("Tax Identification Type 1 Choice")]
    public abstract record TaxIdentificationType1Choice_ { }
}
