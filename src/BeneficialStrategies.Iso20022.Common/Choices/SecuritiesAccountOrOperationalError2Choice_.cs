// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Set of elements used to report between the securities account reference data or an operational error.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountOrOperationalError2Choice.SecuritiesAccountReport))]
    [KnownType(typeof(SecuritiesAccountOrOperationalError2Choice.OperationalError))]
    [JsonDerivedType(typeof(SecuritiesAccountOrOperationalError2Choice.SecuritiesAccountReport),nameof(SecuritiesAccountOrOperationalError2Choice.SecuritiesAccountReport))]
    [JsonDerivedType(typeof(SecuritiesAccountOrOperationalError2Choice.OperationalError),nameof(SecuritiesAccountOrOperationalError2Choice.OperationalError))]
    [IsoId("_txDqoeGEEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Or Operational Error 2 Choice")]
    public abstract partial record SecuritiesAccountOrOperationalError2Choice_
    {
    }
}
