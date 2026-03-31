// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice beween a payment type from a predefined list and a proprietary payment type.
    /// </summary>
    [KnownType(typeof(PaymentType5Choice.Type))]
    [KnownType(typeof(PaymentType5Choice.ProprietaryType))]
    [JsonDerivedType(typeof(PaymentType5Choice.Type), nameof(PaymentType5Choice.Type))]
    [JsonDerivedType(
        typeof(PaymentType5Choice.ProprietaryType),
        nameof(PaymentType5Choice.ProprietaryType)
    )]
    [IsoId("_nBzdgekAEemV35DUs8L82Q")]
    [DisplayName("Payment Type 5 Choice")]
    public abstract record PaymentType5Choice_ { }
}
