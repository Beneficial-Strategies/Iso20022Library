// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the mandate that is being accepted.
    /// </summary>
    [KnownType(typeof(OriginalMandate1Choice.OriginalMandateIdentification))]
    [KnownType(typeof(OriginalMandate1Choice.OriginalMandate))]
    [JsonDerivedType(typeof(OriginalMandate1Choice.OriginalMandateIdentification),nameof(OriginalMandate1Choice.OriginalMandateIdentification))]
    [JsonDerivedType(typeof(OriginalMandate1Choice.OriginalMandate),nameof(OriginalMandate1Choice.OriginalMandate))]
    [IsoId("_RD1Zk9p-Ed-ak6NoX_4Aeg_1242303022")]
    [DisplayName("Original Mandate 1 Choice")]
    public abstract partial record OriginalMandate1Choice_
    {
    }
}
