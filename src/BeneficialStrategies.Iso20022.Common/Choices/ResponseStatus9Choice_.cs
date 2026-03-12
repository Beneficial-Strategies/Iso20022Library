// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Collateral taker&apos;s answer to the collateral giver instruction.
    /// </summary>
    [KnownType(typeof(ResponseStatus9Choice.Code))]
    [KnownType(typeof(ResponseStatus9Choice.Proprietary))]
    [JsonDerivedType(typeof(ResponseStatus9Choice.Code),nameof(ResponseStatus9Choice.Code))]
    [JsonDerivedType(typeof(ResponseStatus9Choice.Proprietary),nameof(ResponseStatus9Choice.Proprietary))]
    [IsoId("_cIPBMLzcEeivTd4NUfCi2g")]
    [DisplayName("Response Status 9 Choice")]
    public abstract partial record ResponseStatus9Choice_
    {
    }
}
