// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the options for the time to maturity.
    /// </summary>
    [KnownType(typeof(TimeToMaturity2Choice.Period))]
    [KnownType(typeof(TimeToMaturity2Choice.Special))]
    [JsonDerivedType(typeof(TimeToMaturity2Choice.Period), nameof(TimeToMaturity2Choice.Period))]
    [JsonDerivedType(typeof(TimeToMaturity2Choice.Special), nameof(TimeToMaturity2Choice.Special))]
    [IsoId("__L6x1a5OEeuo-IflVgGqiA")]
    [DisplayName("Time To Maturity 2 Choice")]
    public abstract record TimeToMaturity2Choice_ { }
}
