// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [KnownType(typeof(MandateClassification1Choice.Code))]
    [KnownType(typeof(MandateClassification1Choice.Proprietary))]
    [JsonDerivedType(typeof(MandateClassification1Choice.Code),nameof(MandateClassification1Choice.Code))]
    [JsonDerivedType(typeof(MandateClassification1Choice.Proprietary),nameof(MandateClassification1Choice.Proprietary))]
    [IsoId("_JThtg2oDEearR-CA7eRZXQ")]
    [DisplayName("Mandate Classification 1 Choice")]
    public abstract partial record MandateClassification1Choice_
    {
    }
}
