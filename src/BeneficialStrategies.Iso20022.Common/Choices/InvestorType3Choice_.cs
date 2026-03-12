// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for investor type.
    /// </summary>
    [KnownType(typeof(InvestorType3Choice.Code))]
    [KnownType(typeof(InvestorType3Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestorType3Choice.Code),nameof(InvestorType3Choice.Code))]
    [JsonDerivedType(typeof(InvestorType3Choice.Proprietary),nameof(InvestorType3Choice.Proprietary))]
    [IsoId("_czZDx-LxEeWOD7aAy2fAcA")]
    [DisplayName("Investor Type 3 Choice")]
    public abstract partial record InvestorType3Choice_
    {
    }
}
