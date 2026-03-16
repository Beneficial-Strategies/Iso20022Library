// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between account details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrBusinessError5Choice.Account))]
    [KnownType(typeof(AccountOrBusinessError5Choice.BusinessError))]
    [JsonDerivedType(
        typeof(AccountOrBusinessError5Choice.Account),
        nameof(AccountOrBusinessError5Choice.Account)
    )]
    [JsonDerivedType(
        typeof(AccountOrBusinessError5Choice.BusinessError),
        nameof(AccountOrBusinessError5Choice.BusinessError)
    )]
    [IsoId("_fDmr0dcZEeqRFcf2R4bPBw")]
    [DisplayName("Account Or Business Error 5 Choice")]
    public abstract record AccountOrBusinessError5Choice_ { }
}
