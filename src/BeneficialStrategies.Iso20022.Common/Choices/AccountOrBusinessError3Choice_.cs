// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between account details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrBusinessError3Choice.Account))]
    [KnownType(typeof(AccountOrBusinessError3Choice.BusinessError))]
    [JsonDerivedType(
        typeof(AccountOrBusinessError3Choice.Account),
        nameof(AccountOrBusinessError3Choice.Account)
    )]
    [JsonDerivedType(
        typeof(AccountOrBusinessError3Choice.BusinessError),
        nameof(AccountOrBusinessError3Choice.BusinessError)
    )]
    [IsoId("_fd0Qx5-WEee28J7y9KlTWg")]
    [DisplayName("Account Or Business Error 3 Choice")]
    public abstract record AccountOrBusinessError3Choice_ { }
}
