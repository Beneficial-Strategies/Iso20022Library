// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies which information are involved by a modification request for securities account reference data.
    /// </summary>
    [KnownType(typeof(SecuritiesAccountModification1Choice.SystemSecuritiesAccount))]
    [KnownType(typeof(SecuritiesAccountModification1Choice.SystemRestriction))]
    [KnownType(typeof(SecuritiesAccountModification1Choice.MarketSpecificAttribute))]
    [JsonDerivedType(typeof(SecuritiesAccountModification1Choice.SystemSecuritiesAccount),nameof(SecuritiesAccountModification1Choice.SystemSecuritiesAccount))]
    [JsonDerivedType(typeof(SecuritiesAccountModification1Choice.SystemRestriction),nameof(SecuritiesAccountModification1Choice.SystemRestriction))]
    [JsonDerivedType(typeof(SecuritiesAccountModification1Choice.MarketSpecificAttribute),nameof(SecuritiesAccountModification1Choice.MarketSpecificAttribute))]
    [IsoId("_hjLnamliEeGaMcKyqKNRfQ_-966924713")]
    [DisplayName("Securities Account Modification 1 Choice")]
    public abstract partial record SecuritiesAccountModification1Choice_
    {
    }
}
