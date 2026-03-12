// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of payment instrument.
    /// </summary>
    [KnownType(typeof(FundPaymentType1Choice.Code))]
    [KnownType(typeof(FundPaymentType1Choice.Proprietary))]
    [JsonDerivedType(typeof(FundPaymentType1Choice.Code),nameof(FundPaymentType1Choice.Code))]
    [JsonDerivedType(typeof(FundPaymentType1Choice.Proprietary),nameof(FundPaymentType1Choice.Proprietary))]
    [IsoId("_4hKBoF8xEeicg40_9gK9vQ")]
    [DisplayName("Fund Payment Type 1 Choice")]
    public abstract partial record FundPaymentType1Choice_
    {
    }
}
