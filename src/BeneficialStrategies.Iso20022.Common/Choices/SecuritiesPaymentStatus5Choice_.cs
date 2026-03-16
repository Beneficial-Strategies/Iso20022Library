// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the status of payment of a security at a particular time.
    /// </summary>
    [KnownType(typeof(SecuritiesPaymentStatus5Choice.Code))]
    [KnownType(typeof(SecuritiesPaymentStatus5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesPaymentStatus5Choice.Code),
        nameof(SecuritiesPaymentStatus5Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesPaymentStatus5Choice.Proprietary),
        nameof(SecuritiesPaymentStatus5Choice.Proprietary)
    )]
    [IsoId("_cBDuUTnAEeWV5sr121Fc8A")]
    [DisplayName("Securities Payment Status 5 Choice")]
    public abstract record SecuritiesPaymentStatus5Choice_ { }
}
