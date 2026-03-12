// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between account details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(AccountOrBusinessError4Choice.Account))]
    [KnownType(typeof(AccountOrBusinessError4Choice.BusinessError))]
    [JsonDerivedType(typeof(AccountOrBusinessError4Choice.Account),nameof(AccountOrBusinessError4Choice.Account))]
    [JsonDerivedType(typeof(AccountOrBusinessError4Choice.BusinessError),nameof(AccountOrBusinessError4Choice.BusinessError))]
    [IsoId("_MtNQV249EeiU9cctagi5ow")]
    [DisplayName("Account Or Business Error 4 Choice")]
    public abstract partial record AccountOrBusinessError4Choice_
    {
    }
}
