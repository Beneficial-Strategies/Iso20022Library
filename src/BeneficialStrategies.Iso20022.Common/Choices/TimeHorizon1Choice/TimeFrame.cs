// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeHorizon1Choice
{
    /// <summary>
    /// Time frame as a qualitative value.
    /// </summary>
    [IsoId("_7x92gDcuEeidBoT_PugKiA")]
    [DisplayName("Time Frame")]
    public record TimeFrame : TimeHorizon1Choice_ { }
}
