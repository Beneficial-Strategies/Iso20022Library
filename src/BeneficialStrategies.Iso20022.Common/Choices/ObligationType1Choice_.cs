// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates the type of obligation.
    /// </summary>
    [KnownType(typeof(ObligationType1Choice.Code))]
    [KnownType(typeof(ObligationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ObligationType1Choice.Code),nameof(ObligationType1Choice.Code))]
    [JsonDerivedType(typeof(ObligationType1Choice.Proprietary),nameof(ObligationType1Choice.Proprietary))]
    [IsoId("_Ql4SSNp-Ed-ak6NoX_4Aeg_-44053834")]
    [DisplayName("Obligation Type 1 Choice")]
    public abstract partial record ObligationType1Choice_
    {
    }
}
