// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode1Choice.Code))]
    [KnownType(typeof(PurposeCode1Choice.Proprietary))]
    [JsonDerivedType(typeof(PurposeCode1Choice.Code), nameof(PurposeCode1Choice.Code))]
    [JsonDerivedType(
        typeof(PurposeCode1Choice.Proprietary),
        nameof(PurposeCode1Choice.Proprietary)
    )]
    [IsoId("_Q-6dUNp-Ed-ak6NoX_4Aeg_-1219342455")]
    [DisplayName("Purpose Code 1 Choice")]
    public abstract record PurposeCode1Choice_ { }
}
