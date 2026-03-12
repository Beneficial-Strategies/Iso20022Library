// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the high level purpose of the instruction based on a set of pre-defined categories.|Usage: This is used by the initiating party to provide information concerning the processing of the payment. It is likely to trigger special processing by any of the agents involved in the payment chain.
    /// </summary>
    [KnownType(typeof(CategoryPurpose1Choice.Code))]
    [KnownType(typeof(CategoryPurpose1Choice.Proprietary))]
    [JsonDerivedType(typeof(CategoryPurpose1Choice.Code),nameof(CategoryPurpose1Choice.Code))]
    [JsonDerivedType(typeof(CategoryPurpose1Choice.Proprietary),nameof(CategoryPurpose1Choice.Proprietary))]
    [IsoId("_THaa5Np-Ed-ak6NoX_4Aeg_1223014142")]
    [DisplayName("Category Purpose 1 Choice")]
    public abstract partial record CategoryPurpose1Choice_
    {
    }
}
