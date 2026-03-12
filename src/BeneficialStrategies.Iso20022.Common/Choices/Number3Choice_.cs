// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of 3 and 5 exact numeric number.
    /// </summary>
    [KnownType(typeof(Number3Choice.Short))]
    [KnownType(typeof(Number3Choice.Long))]
    [JsonDerivedType(typeof(Number3Choice.Short),nameof(Number3Choice.Short))]
    [JsonDerivedType(typeof(Number3Choice.Long),nameof(Number3Choice.Long))]
    [IsoId("_QrP6dNp-Ed-ak6NoX_4Aeg_-1147595422")]
    [DisplayName("Number 3 Choice")]
    public abstract partial record Number3Choice_
    {
    }
}
