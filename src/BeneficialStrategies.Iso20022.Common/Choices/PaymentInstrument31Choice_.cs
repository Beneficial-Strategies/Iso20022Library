// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BeneficialStrategies.Iso20022.Choices.PaymentInstrument31Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between types of payment instrument.</summary>
    [IsoId("a3fe8f32-d51c-4cf3-aca4-de89d9c2d131")]
    [DisplayName("Payment Instrument 31 Choice")]
    [KnownType(typeof(CreditTransferDetails))]
    [KnownType(typeof(ChequeDetails))]
    [JsonDerivedType(typeof(CreditTransferDetails))]
    [JsonDerivedType(typeof(ChequeDetails))]
    public abstract record PaymentInstrument31Choice_;
}
