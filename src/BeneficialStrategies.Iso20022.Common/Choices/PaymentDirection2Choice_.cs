// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the payment direction.
    /// </summary>
    [KnownType(typeof(PaymentDirection2Choice.Indicator))]
    [KnownType(typeof(PaymentDirection2Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentDirection2Choice.Indicator),nameof(PaymentDirection2Choice.Indicator))]
    [JsonDerivedType(typeof(PaymentDirection2Choice.Proprietary),nameof(PaymentDirection2Choice.Proprietary))]
    [IsoId("_Qu-j5tp-Ed-ak6NoX_4Aeg_1993902591")]
    [DisplayName("Payment Direction 2 Choice")]
    public abstract partial record PaymentDirection2Choice_
    {
    }
}
