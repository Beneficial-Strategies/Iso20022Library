// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the status of payment of a security at a particular time.
    /// </summary>
    [KnownType(typeof(SecuritiesPaymentStatus2Choice.Code))]
    [KnownType(typeof(SecuritiesPaymentStatus2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesPaymentStatus2Choice.Code),
        nameof(SecuritiesPaymentStatus2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesPaymentStatus2Choice.Proprietary),
        nameof(SecuritiesPaymentStatus2Choice.Proprietary)
    )]
    [IsoId("_QvHt0Np-Ed-ak6NoX_4Aeg_919791537")]
    [DisplayName("Securities Payment Status 2 Choice")]
    public abstract record SecuritiesPaymentStatus2Choice_ { }
}
