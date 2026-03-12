// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of criteria for the identification of an account.
    /// </summary>
    [KnownType(typeof(AccountSelection1Choice.AccountIdentification))]
    [KnownType(typeof(AccountSelection1Choice.OtherAccountSelectionData))]
    [JsonDerivedType(typeof(AccountSelection1Choice.AccountIdentification),nameof(AccountSelection1Choice.AccountIdentification))]
    [JsonDerivedType(typeof(AccountSelection1Choice.OtherAccountSelectionData),nameof(AccountSelection1Choice.OtherAccountSelectionData))]
    [IsoId("_8u7sACFREeWgV9SQSyaAog")]
    [DisplayName("Account Selection 1 Choice")]
    public abstract partial record AccountSelection1Choice_
    {
    }
}
