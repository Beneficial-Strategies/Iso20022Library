// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the accounting status.
    /// </summary>
    [KnownType(typeof(AccountingStatus1Choice.Code))]
    [KnownType(typeof(AccountingStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountingStatus1Choice.Code),nameof(AccountingStatus1Choice.Code))]
    [JsonDerivedType(typeof(AccountingStatus1Choice.Proprietary),nameof(AccountingStatus1Choice.Proprietary))]
    [IsoId("_9Oz2cCDDEeWPMvNwVtiMsA")]
    [DisplayName("Accounting Status 1 Choice")]
    public abstract partial record AccountingStatus1Choice_
    {
    }
}
