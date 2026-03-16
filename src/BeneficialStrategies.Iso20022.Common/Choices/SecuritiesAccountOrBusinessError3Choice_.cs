// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the securities account reference data or a business error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountOrBusinessError3Choice.SecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountOrBusinessError3Choice.BusinessError))]
    [JsonDerivedType(
        typeof(SecuritiesAccountOrBusinessError3Choice.SecuritiesAccount),
        nameof(SecuritiesAccountOrBusinessError3Choice.SecuritiesAccount)
    )]
    [JsonDerivedType(
        typeof(SecuritiesAccountOrBusinessError3Choice.BusinessError),
        nameof(SecuritiesAccountOrBusinessError3Choice.BusinessError)
    )]
    [IsoId("_yC-g5Tp1Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Or Business Error 3 Choice")]
    public abstract record SecuritiesAccountOrBusinessError3Choice_ { }
}
