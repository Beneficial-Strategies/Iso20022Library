// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the status of the investor profile.
    /// </summary>
    [KnownType(typeof(InvestorProfileStatus1Choice.Code))]
    [KnownType(typeof(InvestorProfileStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestorProfileStatus1Choice.Code),nameof(InvestorProfileStatus1Choice.Code))]
    [JsonDerivedType(typeof(InvestorProfileStatus1Choice.Proprietary),nameof(InvestorProfileStatus1Choice.Proprietary))]
    [IsoId("_pd-vQCDOEeWPMvNwVtiMsA")]
    [DisplayName("Investor Profile Status 1 Choice")]
    public abstract partial record InvestorProfileStatus1Choice_
    {
    }
}
