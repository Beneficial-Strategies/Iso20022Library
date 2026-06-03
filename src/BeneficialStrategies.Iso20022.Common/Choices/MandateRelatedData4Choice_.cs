// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between direct debit mandate and credit transfer mandate data.</summary>
    [KnownType(typeof(MandateRelatedData4Choice.DirectDebitMandate))]
    [JsonDerivedType(typeof(MandateRelatedData4Choice.DirectDebitMandate), nameof(MandateRelatedData4Choice.DirectDebitMandate))]
    [KnownType(typeof(MandateRelatedData4Choice.CreditTransferMandate))]
    [JsonDerivedType(typeof(MandateRelatedData4Choice.CreditTransferMandate), nameof(MandateRelatedData4Choice.CreditTransferMandate))]
    [IsoId("_MIUXY7vHEfCYYbmqNrQFSg")]
    [DisplayName("Mandate Related Data 4 Choice")]
    public abstract record MandateRelatedData4Choice_ { }
}
