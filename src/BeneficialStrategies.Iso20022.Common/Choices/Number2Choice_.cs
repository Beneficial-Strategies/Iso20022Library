// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number2Choice.Short))]
    [KnownType(typeof(Number2Choice.Long))]
    [JsonDerivedType(typeof(Number2Choice.Short), nameof(Number2Choice.Short))]
    [JsonDerivedType(typeof(Number2Choice.Long), nameof(Number2Choice.Long))]
    [IsoId("_Qu0y5Np-Ed-ak6NoX_4Aeg_-1987698151")]
    [DisplayName("Number 2 Choice")]
    public abstract record Number2Choice_ { }
}
