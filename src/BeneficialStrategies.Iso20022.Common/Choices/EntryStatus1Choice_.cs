// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of an entry on the books of the account servicer.
    /// </summary>
    [KnownType(typeof(EntryStatus1Choice.Code))]
    [KnownType(typeof(EntryStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(EntryStatus1Choice.Code), nameof(EntryStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(EntryStatus1Choice.Proprietary),
        nameof(EntryStatus1Choice.Proprietary)
    )]
    [IsoId("_DICS8IaoEeeUws0ZryHQ2w")]
    [DisplayName("Entry Status 1 Choice")]
    public abstract record EntryStatus1Choice_ { }
}
