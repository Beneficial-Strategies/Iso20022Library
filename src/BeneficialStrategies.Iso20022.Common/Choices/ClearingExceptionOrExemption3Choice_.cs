// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about contract status.
    /// </summary>
    [KnownType(typeof(ClearingExceptionOrExemption3Choice.Reason))]
    [KnownType(typeof(ClearingExceptionOrExemption3Choice.Counterparties))]
    [JsonDerivedType(
        typeof(ClearingExceptionOrExemption3Choice.Reason),
        nameof(ClearingExceptionOrExemption3Choice.Reason)
    )]
    [JsonDerivedType(
        typeof(ClearingExceptionOrExemption3Choice.Counterparties),
        nameof(ClearingExceptionOrExemption3Choice.Counterparties)
    )]
    [IsoId("_Ah8Gl5PuEey0rJ3Gl6WZVA")]
    [DisplayName("Clearing Exception Or Exemption 3 Choice")]
    public abstract record ClearingExceptionOrExemption3Choice_ { }
}
