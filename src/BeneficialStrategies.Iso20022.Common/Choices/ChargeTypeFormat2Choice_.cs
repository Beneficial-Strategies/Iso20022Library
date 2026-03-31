// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Type of charge expressed either in free format or in structured or free form.
    /// </summary>
    [KnownType(typeof(ChargeTypeFormat2Choice.Unstructured))]
    [KnownType(typeof(ChargeTypeFormat2Choice.Structured))]
    [JsonDerivedType(
        typeof(ChargeTypeFormat2Choice.Unstructured),
        nameof(ChargeTypeFormat2Choice.Unstructured)
    )]
    [JsonDerivedType(
        typeof(ChargeTypeFormat2Choice.Structured),
        nameof(ChargeTypeFormat2Choice.Structured)
    )]
    [IsoId("_UyQMF9p-Ed-ak6NoX_4Aeg_1822769667")]
    [DisplayName("Charge Type Format 2 Choice")]
    public abstract record ChargeTypeFormat2Choice_ { }
}
