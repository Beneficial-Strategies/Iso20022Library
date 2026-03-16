// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the affirmation status.
    /// </summary>
    [KnownType(typeof(AffirmationStatus1Choice.Code))]
    [KnownType(typeof(AffirmationStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(AffirmationStatus1Choice.Code), nameof(AffirmationStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(AffirmationStatus1Choice.Proprietary),
        nameof(AffirmationStatus1Choice.Proprietary)
    )]
    [IsoId("_UaaT2Np-Ed-ak6NoX_4Aeg_674653876")]
    [DisplayName("Affirmation Status 1 Choice")]
    public abstract record AffirmationStatus1Choice_ { }
}
