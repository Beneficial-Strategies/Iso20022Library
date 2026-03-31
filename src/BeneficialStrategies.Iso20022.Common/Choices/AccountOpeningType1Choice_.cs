// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the account opening type.
    /// </summary>
    [KnownType(typeof(AccountOpeningType1Choice.Code))]
    [KnownType(typeof(AccountOpeningType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AccountOpeningType1Choice.Code),
        nameof(AccountOpeningType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AccountOpeningType1Choice.Proprietary),
        nameof(AccountOpeningType1Choice.Proprietary)
    )]
    [IsoId("_wuO4IEzJEeafiMTDrtSnyw")]
    [DisplayName("Account Opening Type 1 Choice")]
    public abstract record AccountOpeningType1Choice_ { }
}
