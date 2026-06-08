// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using BeneficialStrategies.Iso20022.Choices.PaymentMethod3Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Method of payment for the remittance of the CSD or the NCB to the invoicing party.</summary>
    [IsoId("_5qS_MdEvEfCli6pH8hj5ag")]
    [DisplayName("Payment Method 3 Choice")]
    [KnownType(typeof(Code))]
    [KnownType(typeof(Proprietary))]
    [JsonDerivedType(typeof(Code))]
    [JsonDerivedType(typeof(Proprietary))]
    public abstract record PaymentMethod3Choice_;
}
