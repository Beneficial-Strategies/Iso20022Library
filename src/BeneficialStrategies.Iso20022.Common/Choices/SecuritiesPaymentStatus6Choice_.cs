// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the status of payment of a security at a particular time.
    /// </summary>
    [KnownType(typeof(SecuritiesPaymentStatus6Choice.Code))]
    [KnownType(typeof(SecuritiesPaymentStatus6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesPaymentStatus6Choice.Code),
        nameof(SecuritiesPaymentStatus6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesPaymentStatus6Choice.Proprietary),
        nameof(SecuritiesPaymentStatus6Choice.Proprietary)
    )]
    [IsoId("_5NZ7p5NLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Payment Status 6 Choice")]
    public abstract record SecuritiesPaymentStatus6Choice_ { }
}
