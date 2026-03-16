// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason why the verified identification information is incorrect.
    /// </summary>
    [KnownType(typeof(VerificationReason1Choice.Code))]
    [KnownType(typeof(VerificationReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(VerificationReason1Choice.Code),
        nameof(VerificationReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(VerificationReason1Choice.Proprietary),
        nameof(VerificationReason1Choice.Proprietary)
    )]
    [IsoId("_Qo3U1Np-Ed-ak6NoX_4Aeg_-449981895")]
    [DisplayName("Verification Reason 1 Choice")]
    public abstract record VerificationReason1Choice_ { }
}
