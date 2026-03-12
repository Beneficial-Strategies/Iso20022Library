// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for investor restriction type.
    /// </summary>
    [KnownType(typeof(InvestorRestrictionType3Choice.Code))]
    [KnownType(typeof(InvestorRestrictionType3Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestorRestrictionType3Choice.Code),nameof(InvestorRestrictionType3Choice.Code))]
    [JsonDerivedType(typeof(InvestorRestrictionType3Choice.Proprietary),nameof(InvestorRestrictionType3Choice.Proprietary))]
    [IsoId("_dF_PpeLxEeWOD7aAy2fAcA")]
    [DisplayName("Investor Restriction Type 3 Choice")]
    public abstract partial record InvestorRestrictionType3Choice_
    {
    }
}
