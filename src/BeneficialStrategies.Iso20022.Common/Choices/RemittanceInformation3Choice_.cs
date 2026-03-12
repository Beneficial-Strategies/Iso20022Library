// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, eg, commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [KnownType(typeof(RemittanceInformation3Choice.Unstructured))]
    [KnownType(typeof(RemittanceInformation3Choice.Structured))]
    [JsonDerivedType(typeof(RemittanceInformation3Choice.Unstructured),nameof(RemittanceInformation3Choice.Unstructured))]
    [JsonDerivedType(typeof(RemittanceInformation3Choice.Structured),nameof(RemittanceInformation3Choice.Structured))]
    [IsoId("_Rb1C1tp-Ed-ak6NoX_4Aeg_-609212220")]
    [DisplayName("Remittance Information 3 Choice")]
    public abstract partial record RemittanceInformation3Choice_
    {
    }
}
