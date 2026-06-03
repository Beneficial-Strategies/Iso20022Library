// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between direct debit mandate and credit transfer mandate data.</summary>
    [KnownType(typeof(MandateRelatedData5Choice.DirectDebitMandate))]
    [JsonDerivedType(typeof(MandateRelatedData5Choice.DirectDebitMandate), nameof(MandateRelatedData5Choice.DirectDebitMandate))]
    [KnownType(typeof(MandateRelatedData5Choice.CreditTransferMandate))]
    [JsonDerivedType(typeof(MandateRelatedData5Choice.CreditTransferMandate), nameof(MandateRelatedData5Choice.CreditTransferMandate))]
    [IsoId("_RA3lIbvIEfCYYbmqNrQFSg")]
    [DisplayName("Mandate Related Data 5 Choice")]
    public abstract record MandateRelatedData5Choice_ { }
}
