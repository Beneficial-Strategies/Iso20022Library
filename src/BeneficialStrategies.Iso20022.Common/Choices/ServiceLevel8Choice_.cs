// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the service level of the transaction.
    /// </summary>
    [KnownType(typeof(ServiceLevel8Choice.Code))]
    [KnownType(typeof(ServiceLevel8Choice.Proprietary))]
    [JsonDerivedType(typeof(ServiceLevel8Choice.Code), nameof(ServiceLevel8Choice.Code))]
    [JsonDerivedType(
        typeof(ServiceLevel8Choice.Proprietary),
        nameof(ServiceLevel8Choice.Proprietary)
    )]
    [IsoId("_QJa_zNp-Ed-ak6NoX_4Aeg_1912716963")]
    [DisplayName("Service Level 8 Choice")]
    public abstract record ServiceLevel8Choice_ { }
}
