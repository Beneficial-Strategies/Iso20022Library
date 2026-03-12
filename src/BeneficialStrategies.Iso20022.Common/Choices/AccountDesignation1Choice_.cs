// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the designation of an account.
    /// </summary>
    [KnownType(typeof(AccountDesignation1Choice.Code))]
    [KnownType(typeof(AccountDesignation1Choice.Proprietary))]
    [JsonDerivedType(typeof(AccountDesignation1Choice.Code),nameof(AccountDesignation1Choice.Code))]
    [JsonDerivedType(typeof(AccountDesignation1Choice.Proprietary),nameof(AccountDesignation1Choice.Proprietary))]
    [IsoId("_gpWFICCzEeWJd9HF2tO7BA")]
    [DisplayName("Account Designation 1 Choice")]
    public abstract partial record AccountDesignation1Choice_
    {
    }
}
