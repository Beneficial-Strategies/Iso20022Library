// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Mandate Related Data3Choice.
    /// </summary>
    [KnownType(typeof(MandateRelatedData3Choice.CreditTransferMandate))]
    [KnownType(typeof(MandateRelatedData3Choice.DirectDebitMandate))]
    [JsonDerivedType(
        typeof(MandateRelatedData3Choice.CreditTransferMandate),
        nameof(MandateRelatedData3Choice.CreditTransferMandate)
    )]
    [JsonDerivedType(
        typeof(MandateRelatedData3Choice.DirectDebitMandate),
        nameof(MandateRelatedData3Choice.DirectDebitMandate)
    )]
    [IsoId("_wHahsTEyEe6g-ffJsqGiSA")]
    [DisplayName("Mandate Related Data3Choice")]
    public abstract record MandateRelatedData3Choice_ { }
}
