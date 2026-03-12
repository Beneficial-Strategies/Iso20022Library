// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the specification of a tax.
    /// </summary>
    [KnownType(typeof(TaxAmountOrRate4Choice.Amount))]
    [KnownType(typeof(TaxAmountOrRate4Choice.Rate))]
    [JsonDerivedType(typeof(TaxAmountOrRate4Choice.Amount),nameof(TaxAmountOrRate4Choice.Amount))]
    [JsonDerivedType(typeof(TaxAmountOrRate4Choice.Rate),nameof(TaxAmountOrRate4Choice.Rate))]
    [IsoId("_mnR34EUWEea21qTBwbMSEA")]
    [DisplayName("Tax Amount Or Rate 4 Choice")]
    public abstract partial record TaxAmountOrRate4Choice_
    {
    }
}
