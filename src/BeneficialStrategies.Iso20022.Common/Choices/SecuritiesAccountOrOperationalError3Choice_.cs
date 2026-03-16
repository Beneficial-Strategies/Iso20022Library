// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements used to report between the securities account reference data or an operational error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountOrOperationalError3Choice.SecuritiesAccountReport))]
    [KnownType(typeof(SecuritiesAccountOrOperationalError3Choice.OperationalError))]
    [JsonDerivedType(
        typeof(SecuritiesAccountOrOperationalError3Choice.SecuritiesAccountReport),
        nameof(SecuritiesAccountOrOperationalError3Choice.SecuritiesAccountReport)
    )]
    [JsonDerivedType(
        typeof(SecuritiesAccountOrOperationalError3Choice.OperationalError),
        nameof(SecuritiesAccountOrOperationalError3Choice.OperationalError)
    )]
    [IsoId("_xuZ_ETp1Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Or Operational Error 3 Choice")]
    public abstract record SecuritiesAccountOrOperationalError3Choice_ { }
}
