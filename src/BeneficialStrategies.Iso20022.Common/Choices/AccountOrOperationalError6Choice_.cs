// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Or Operational Error6Choice.
    /// </summary>
    [KnownType(typeof(AccountOrOperationalError6Choice.AccountReport))]
    [KnownType(typeof(AccountOrOperationalError6Choice.OperationalError))]
    [JsonDerivedType(
        typeof(AccountOrOperationalError6Choice.AccountReport),
        nameof(AccountOrOperationalError6Choice.AccountReport)
    )]
    [JsonDerivedType(
        typeof(AccountOrOperationalError6Choice.OperationalError),
        nameof(AccountOrOperationalError6Choice.OperationalError)
    )]
    [IsoId("_3xRPATEyEe6g-ffJsqGiSA")]
    [DisplayName("Account Or Operational Error6Choice")]
    public abstract record AccountOrOperationalError6Choice_ { }
}
