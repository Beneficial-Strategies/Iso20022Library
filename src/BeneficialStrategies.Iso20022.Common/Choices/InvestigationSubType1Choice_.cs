// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Sub Type1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationSubType1Choice.Code))]
    [KnownType(typeof(InvestigationSubType1Choice.Proprietary))]
    [JsonDerivedType(typeof(InvestigationSubType1Choice.Code),nameof(InvestigationSubType1Choice.Code))]
    [JsonDerivedType(typeof(InvestigationSubType1Choice.Proprietary),nameof(InvestigationSubType1Choice.Proprietary))]
    [IsoId("_CXmCnFRtEe23M4WgERMsYw")]
    [DisplayName("Investigation Sub Type1Choice")]
    public abstract partial record InvestigationSubType1Choice_
    {
    }
}
