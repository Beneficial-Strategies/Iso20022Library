// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of mandate related information.
    /// </summary>
    [KnownType(typeof(MandateRelatedData1Choice.DirectDebitMandate))]
    [KnownType(typeof(MandateRelatedData1Choice.CreditTransferMandate))]
    [JsonDerivedType(typeof(MandateRelatedData1Choice.DirectDebitMandate),nameof(MandateRelatedData1Choice.DirectDebitMandate))]
    [JsonDerivedType(typeof(MandateRelatedData1Choice.CreditTransferMandate),nameof(MandateRelatedData1Choice.CreditTransferMandate))]
    [IsoId("_su3YJ8lxEem0vqvvoqYsqQ")]
    [DisplayName("Mandate Related Data 1 Choice")]
    public abstract partial record MandateRelatedData1Choice_
    {
    }
}
