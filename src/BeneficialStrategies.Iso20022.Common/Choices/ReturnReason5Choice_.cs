// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the return of the transaction.
    /// </summary>
    [KnownType(typeof(ReturnReason5Choice.Code))]
    [KnownType(typeof(ReturnReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(ReturnReason5Choice.Code), nameof(ReturnReason5Choice.Code))]
    [JsonDerivedType(
        typeof(ReturnReason5Choice.Proprietary),
        nameof(ReturnReason5Choice.Proprietary)
    )]
    [IsoId("_TP6Pkdp-Ed-ak6NoX_4Aeg_-1676326037")]
    [DisplayName("Return Reason 5 Choice")]
    public abstract record ReturnReason5Choice_ { }
}
