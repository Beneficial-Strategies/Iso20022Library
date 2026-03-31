// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of mandate related information.
    /// </summary>
    [KnownType(typeof(MandateRelatedData2Choice.DirectDebitMandate))]
    [KnownType(typeof(MandateRelatedData2Choice.CreditTransferMandate))]
    [JsonDerivedType(
        typeof(MandateRelatedData2Choice.DirectDebitMandate),
        nameof(MandateRelatedData2Choice.DirectDebitMandate)
    )]
    [JsonDerivedType(
        typeof(MandateRelatedData2Choice.CreditTransferMandate),
        nameof(MandateRelatedData2Choice.CreditTransferMandate)
    )]
    [IsoId("_a24zwdcZEeqRFcf2R4bPBw")]
    [DisplayName("Mandate Related Data 2 Choice")]
    public abstract record MandateRelatedData2Choice_ { }
}
