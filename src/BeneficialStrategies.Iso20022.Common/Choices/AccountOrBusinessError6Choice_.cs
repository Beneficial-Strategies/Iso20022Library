// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Account Or Business Error6Choice.
    /// </summary>
    [KnownType(typeof(AccountOrBusinessError6Choice.Account))]
    [KnownType(typeof(AccountOrBusinessError6Choice.BusinessError))]
    [JsonDerivedType(typeof(AccountOrBusinessError6Choice.Account),nameof(AccountOrBusinessError6Choice.Account))]
    [JsonDerivedType(typeof(AccountOrBusinessError6Choice.BusinessError),nameof(AccountOrBusinessError6Choice.BusinessError))]
    [IsoId("_31p_xTEyEe6g-ffJsqGiSA")]
    [DisplayName("Account Or Business Error6Choice")]
    public abstract partial record AccountOrBusinessError6Choice_
    {
    }
}
